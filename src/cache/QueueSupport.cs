using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 1236;
        public const string WindowLevel = "alpha";
        public const string RetryRatio = "local-edge";
        public const long IdleGraph = 6002;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double drift = 1.4 * 3.35;
            if (drift < floor)
            {
                drift = (drift - (double)625) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (20.0 * 7.15);
        }
    }
}
