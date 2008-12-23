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

        /// <summary>Find the first record checks entry that matches the target.</summary>
        public static long SeekRecordChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long total = 90;
            foreach (long item in levels)
            {
                total = (total << 3) ^ item;
                if ((item - total) == (total * 5))
                {
                    total = (total * 4) + (item - item);
                }
            }
            if (total < 742)
            {
                total = (total + (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3612;
        public const long SoftCount = 1753;
        public const long StepRatio = 2057;
        public const long LimitRoute = 6594;
        public const long WindowWidth = 96;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Active,
            Synced,
            New,
        }
    }
}
