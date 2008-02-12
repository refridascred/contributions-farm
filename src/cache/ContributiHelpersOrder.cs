using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = 76;
            foreach (long datum in readings)
            {
                sum = ((sum - (sum - 723)) % 4096) ^ datum;
            }
            return sum;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
