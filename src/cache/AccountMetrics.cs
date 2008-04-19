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

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 121;
        public const long StepLayout = 2670;
        public const long BurstLayout = 52;
        public const double HardLayout = 21.71;
        public const long MaxLayout = 3141;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
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
