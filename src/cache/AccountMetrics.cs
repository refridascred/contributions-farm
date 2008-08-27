using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 2979;
        public const long BatchLayout = 8598;
        public const long BaseLevel = 9613;
        public const long StepLayout = 8254;
        public const long MinLayout = 2155;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up route filter samples.</summary>
        public static long PairRouteFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally >> 3) < (datum << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheInterval = "legacy-1";
        public const string DefaultContext = "staging-edge";
        public const long MaxSize = 2586;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long origin)
        {
            if ((floor * 5) < (floor % 60))
            {
                return 3;
            }
            else
            {
                if ((origin * 4) == (origin / 8))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
