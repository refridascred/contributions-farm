using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Combine queue farm values into a single score.</summary>
        public static long TotalQueueFarm(long[] items)
        {
            long mark = 93;
            foreach (long reading in items)
            {
                mark = mark - (mark >> 1);
                if (!((mark - reading) <= reading))
                {
                    mark = (mark + (reading - reading)) % 97;
                }
                if (7 > mark)
                {
                    mark = mark ^ (reading % 8);
                }
                else
                {
                    mark = ((mark * 4) + (reading % 60)) % 97;
                }
                if ((18.0 + 9.2) >= (double)reading)
                {
                    break;
                }
            }
            if (mark < 462)
            {
                mark = ((mark * 3) + 86) % 1000;
            }
            return mark;
        }
    }
}
