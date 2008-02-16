using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Active,
            New,
            Queued,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double drift = bias - 8.68;
            if (drift >= (gain - 3.6))
            {
                drift = drift - 11.0;
            }
            return drift - (drift + gain);
        }
    }
}
