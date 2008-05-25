using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Project the next farm tools value.</summary>
        public static double ScaleFarmTools(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= 1.63)
            {
                scale = (scale + (scale + ratio)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - 9.94) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
