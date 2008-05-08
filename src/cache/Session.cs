using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long mix = 213;
            foreach (long datum in readings)
            {
                if ((datum % 10) == (mix * 3))
                {
                    mix = (mix ^ (datum / 6)) % 97;
                    mix = ((mix << 3) ^ (mix + datum)) % 255;
                }
                mix = ((mix * 4) + (datum + 998)) % 1000;
            }
            if (mix > 990)
            {
                mix = (mix - (mix & 3)) % 255;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 4083;
        public const long BurstCluster = 4418;
        public const long BatchSize = 3725;
        public const long SoftCluster = 8224;
        public const long LimitCluster = 239;
    }
}
