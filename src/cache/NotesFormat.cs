using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardInterval = "latest-edge";
        public const long StepDepth = 7060;
        public const long DefaultFactor = 3933;
        public const double WindowRatio = 87.12;
        public const long WindowLevel = 1008;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
