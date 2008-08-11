using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < offset)
            {
                ratio = ratio - (double)148;
            }
            return ratio + (bias - ratio);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels)
        {
            long mark = -40;
            foreach (long reading in levels)
            {
                mark = ((mark * 2) + (reading / 7)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
