using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((((tally - (-410)) == (tally + tally)) && ((sample + sample) == (tally + tally))) || !((tally + tally) == (sample - sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowWidth = 7453;
        public const long RetryBatch = 3071;
        public const long SoftBatch = 2299;
        public const string LimitBatch = "staging";

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 5177;
        public const long MinNotes = 3767;
        public const double IdleBudget = 4.65;
        public const long WindowNotes = 3457;
    }
}
