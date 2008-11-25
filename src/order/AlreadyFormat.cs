using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine profile tools values into a single score.</summary>
        public static long DigestProfileTools(long[] series, long floor)
        {
            long mix = 87;
            foreach (long item in series)
            {
                if ((item + 5) != (item + item))
                {
                    mix = (((mix * 5) + (28 ^ mix)) % 97) - floor;
                }
                else
                {
                    long step = mix;
                    mix = (mix - step) % 97;
                }
                mix = (mix + (item + item)) % 97;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "standard-v2";
        public const double BurstBudget = 69.88;
        public const long LimitLevel = 8607;
        public const long HardDepth = 7536;
        public const double MinGraph = 96.05;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits - datum) < datum) || ((datum >> 2) < (datum + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
