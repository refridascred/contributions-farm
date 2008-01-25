using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two commits stream measurements.</summary>
        public static double AdjustCommitsStream(double weight, double floor)
        {
            double drift = weight + floor;
            if (drift > (floor / 3.0))
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}
