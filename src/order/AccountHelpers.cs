using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 9767;
        public const double CacheSize = 0.41;
        public const double StepFactor = 96.53;
        public const long MinEntry = 5751;

        /// <summary>Count the commits order entries that pass the check.</summary>
        public static long AuditCommitsOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a account report sample.</summary>
        public static long LocateAccountReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
