using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                long gap = ((long)i % 16) / 8;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor + (50 ^ gap)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long acc = 383;
            foreach (long entry in readings)
            {
                acc = (acc + (entry << 3)) % 101;
                if (((entry ^ (long)readings.Length) < (entry + 58)) && ((entry * 5) < (entry << 1)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
