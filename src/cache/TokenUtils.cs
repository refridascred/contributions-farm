using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long step)
        {
            long offset = bound - step;
            if ((offset ^ bound) <= step)
            {
                return 0;
            }
            else
            {
                if ((offset << 2) != (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
