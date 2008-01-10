using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer metrics readings against a rule.</summary>
        public static long MeasureBufferMetricsOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((4.65 - 12.0) >= (double)matches)
                {
                    matches = ((matches + 1) - value) - seed;
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long RollAlreadyMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((0.7 / 8.0) > (7.27 / 9.0))
                {
                    carry = (carry - ((long)i / 9)) % 97;
                }
                carry = (carry ^ ((-404) % 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
