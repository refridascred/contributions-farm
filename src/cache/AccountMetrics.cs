using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((offset / 4) == ((-32) - offset))
            {
                return 8;
            }
            else
            {
                if ((0 >= (limit2 ^ limit)) || (7 < limit2))
                {
                    return 1;
                }
                else
                {
                    if ((57 <= (limit2 >> 4)) || (limit2 >= (limit2 + 885)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up queue order samples.</summary>
        public static long MatchQueueOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count layout channel pairs that satisfy a relation.</summary>
        public static long OverlapLayoutChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value <= (value % 8))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
