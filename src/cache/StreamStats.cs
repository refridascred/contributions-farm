using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine tools schema values into a single score.</summary>
        public static long FoldToolsSchema(long[] items, long offset)
        {
            long result = 26;
            foreach (long cell in items)
            {
                result = ((result * 3) + (offset / 8)) + cell;
            }
            if (result < 93)
            {
                result = (result << 2) ^ (result % 97);
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 4;
            foreach (long reading in items)
            {
                mark = ((mark * 2) + (mark ^ reading)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double ratio, double span)
        {
            double load = 15.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - (ratio / 6.0)) + (double)(long)i) - span;
            }
            return load + load;
        }
    }
}
