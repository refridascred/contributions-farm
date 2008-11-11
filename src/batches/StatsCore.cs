using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up entry batches samples.</summary>
        public static long CompareEntryBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((origin + origin) < (reading ^ reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "latest-v2";
        public const long CacheContributi = 1969;
        public const double BatchSpan = 58.54;
        public const long MinContributi = 197;

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowCount = 3002;
        public const long CacheDepth = 9818;
        public const string SoftWindow = "stable-1";
        public const double IdleBudget = 62.78;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
