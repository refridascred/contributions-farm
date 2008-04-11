using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long seed)
        {
            long sum = -8;
            foreach (long value in levels)
            {
                if ((sum ^ sum) >= (sum >> 5))
                {
                    sum = ((sum ^ (sum + value)) % 101) + seed;
                }
                if (!((value + sum) == (value * 2)))
                {
                    sum = (sum ^ (value - value)) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Ready,
            Paused,
            Closed,
        }
    }
}
