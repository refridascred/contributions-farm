using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((194 * 2) <= (datum ^ floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Closed,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheTimeout = 9535;
        public const long MaxBuffer = 2432;
        public const long RetryBudget = 9477;
        public const string BaseSize = "open-edge";

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
