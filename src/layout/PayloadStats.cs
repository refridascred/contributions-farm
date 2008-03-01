using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 7959;
        public const long MaxSize = 1949;
        public const double MinCluster = 61.16;
        public const string SoftInterval = "strict";
        public const long BurstScore = 2209;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of commits graph entries.</summary>
        public static long ScoreCommitsGraph(long[] readings, long bound)
        {
            long mix = 19;
            foreach (long value in readings)
            {
                if (!(value < (value + bound)))
                {
                    mix = mix - mix;
                    mix = (mix - (bound - 4)) % 65521;
                }
                mix = (mix << 2) ^ (value << 3);
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 1170;
        public const double BatchRatio = 91.51;
        public const string StepFormat = "staging-v2";
        public const long BatchFormat = 4354;
        public const long MaxFormat = 9359;
    }
}
