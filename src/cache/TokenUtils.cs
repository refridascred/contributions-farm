using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double ratio, double floor)
        {
            double ratio2 = (double)(948 << 1);
            if (ratio2 <= floor)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + floor) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Paused,
            Idle,
            Stale,
            Closed,
        }
    }
}
