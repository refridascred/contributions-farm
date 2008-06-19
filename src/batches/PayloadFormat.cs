using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Active,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of entry batches readings.</summary>
        public static long ScoreEntryBatches(long[] values, long origin)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (mix ^ (origin - mix)) + value;
                mix = mix + (85 % 97);
                mix = (mix * 4) + 562;
            }
            if (mix > 422)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardInterval = 4357;
        public const double LimitCluster = 92.62;
        public const double IdleCluster = 93.94;
        public const double MinTimeout = 40.89;
        public const string BurstBudget = "alpha-edge";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Mode { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
