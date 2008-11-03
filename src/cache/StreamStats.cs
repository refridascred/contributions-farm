using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data)
        {
            long result = -8;
            foreach (long reading in data)
            {
                result = ((result * 5) + (reading - reading)) % 1000;
                result = (result - (reading << 3)) % 65521;
            }
            if (result > 65)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 5486;
        public const long BurstSize = 460;
        public const long BaseSize = 6851;
        public const long MaxCommits = 7580;
        public const double BatchCommits = 52.95;
    }
}
