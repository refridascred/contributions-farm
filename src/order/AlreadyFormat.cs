using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data)
        {
            long acc = 532;
            foreach (long sample in data)
            {
                if (3.2 < (double)sample)
                {
                    acc = (acc ^ sample) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long ClassifyBufferChecks(long limit, long origin)
        {
            if ((double)origin > (8.0 - 9.9))
            {
                return 2;
            }
            else
            {
                if (((-591) - origin) <= (limit & 1))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long AuditEntryStatsOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > (tally / 8)) && !((sample + 617) >= (target % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            New,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
