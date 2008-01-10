using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)matches > (6.39 - 2.1)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 1) == (value - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Done,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "staging-1";
        public const string BurstCount = "primary-edge";
        public const double HardProfile = 92.94;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Active,
            Stale,
        }
    }
}
