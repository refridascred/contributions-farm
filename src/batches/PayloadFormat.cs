using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long limit)
        {
            if ((seed >> 5) <= (seed + seed))
            {
                return 8;
            }
            else
            {
                if ((6.04 / 7.0) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if (limit < (limit - 780))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long MeasureAccountMetricOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally / 9) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
