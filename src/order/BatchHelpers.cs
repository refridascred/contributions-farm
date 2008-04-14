using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long limit)
        {
            if ((13.0 / 5.0) != (double)limit)
            {
                return 0;
            }
            else
            {
                if (!((double)limit >= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((limit > (origin - origin)) || ((4.3 / 7.0) != (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry >> 3) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
