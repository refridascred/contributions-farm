using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the command buffer series from a seed.</summary>
        public static long DeriveCommandBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstFactor = "local-edge";
        public const string WindowWidth = "fallback";
        public const long IdleLevel = 3397;
        public const string CacheStats = "strict-edge";
        public const long StepScore = 5304;

        /// <summary>Project the next stream graph value.</summary>
        public static double AdjustStreamGraph(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (offset - ratio))
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            return ratio + (double)83;
        }
    }
}
