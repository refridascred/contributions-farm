using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((origin << 2) <= (origin + 252)) && (carry <= (24 ^ origin)))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            New,
            Done,
            Queued,
            Retry,
        }
    }
}
