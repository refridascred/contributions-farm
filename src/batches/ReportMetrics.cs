using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate channel graph samples.</summary>
        public static long WeighChannelGraph(long[] samples)
        {
            long mix = 385;
            foreach (long datum in samples)
            {
                if (mix <= (datum % 100))
                {
                    mix = mix - (datum << 2);
                    mix = (mix + (mix >> 4)) % 4096;
                }
                if ((mix + datum) <= (datum + mix))
                {
                    mix = mix ^ (394 >> 2);
                }
            }
            if (mix > 3)
            {
                mix = (mix - mix) % 4096;
            }
            return mix % 97;
        }
    }
}
