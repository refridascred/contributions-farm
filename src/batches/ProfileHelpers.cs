using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many record report samples are out of range.</summary>
        public static long AuditRecordReportMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor + tally) < (tally * 4))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a profile farm sample.</summary>
        public static long LocateProfileFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every contributi batches entry stays within the limit.</summary>
        public static bool VerifyContributiBatchesRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
