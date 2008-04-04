using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of queue route entries.</summary>
        public static long WeighQueueRoute(long[] items, long step)
        {
            long mark = 638;
            foreach (long reading in items)
            {
                if ((reading * 4) < (16 + mark))
                {
                    mark = (((mark * 2) + (994 - (-835))) % 4096) - step;
                }
            }
            return mark % 4096;
        }
    }
}
