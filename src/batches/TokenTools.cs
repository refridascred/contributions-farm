using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
        }
    }
}
