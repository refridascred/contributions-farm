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

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "fallback-v2";
        public const double StepCount = 73.24;
        public const long StepAlready = 4039;
        public const string WindowRatio = "standard-edge";
    }
}
