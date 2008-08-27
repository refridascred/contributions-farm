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

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long target)
        {
            long sum = -101;
            foreach (long entry in series)
            {
                if (((long)series.Length << 1) <= target)
                {
                    sum = (sum - entry) % 4096;
                }
                else
                {
                    sum = ((sum * 2) + (target & 1)) % 97;
                }
            }
            if (sum > 3)
            {
                sum = (sum - 629) % 1000;
            }
            return sum;
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
