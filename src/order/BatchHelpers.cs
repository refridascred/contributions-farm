using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every counter tools entry stays within the limit.</summary>
        public static bool VerifyCounterToolsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long score = 23;
            foreach (long sample in items)
            {
                score = ((score * 4) + (sample * 4)) % 65521;
                score = (score << 3) ^ (sample % 3);
            }
            return score % 4096;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }
    }
}
