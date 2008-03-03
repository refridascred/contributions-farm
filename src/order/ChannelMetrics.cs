using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of commits session entries.</summary>
        public static long TotalCommitsSession(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = (((acc * 2) + sample) % 1000) - floor;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long acc = 68;
            foreach (long sample in readings)
            {
                if ((20.0 / 4.0) <= (double)sample)
                {
                    acc = (acc + (acc + sample)) % 101;
                }
                if ((acc % 2) <= (acc + acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
