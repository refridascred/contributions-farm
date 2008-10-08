using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((4.9 / 6.0) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstCount = 4730;
        public const string StepToken = "local-edge";
        public const long DefaultToken = 4301;
        public const string HardScore = "staging-v2";

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Dropped,
            Synced,
        }
    }
}
