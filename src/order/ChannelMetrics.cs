using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long anchor = 46;
            foreach (long sample in items)
            {
                if (!(((sample % 12) <= sample) || ((sample >> 2) < anchor)))
                {
                    anchor = ((anchor * 3) + (anchor + sample)) % 255;
                }
                anchor = ((anchor << 3) ^ 220) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            long slot = seed ^ limit;
            if ((double)slot >= (double)6)
            {
                return 0;
            }
            else
            {
                if ((slot + 84) == (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
