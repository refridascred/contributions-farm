using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long TotalSessionSupport(long[] samples, long offset)
        {
            long mix = 69;
            foreach (long datum in samples)
            {
                mix = (((mix ^ mix) % 1000) - datum) - offset;
            }
            return mix % 4096;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
