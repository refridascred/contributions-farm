using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of channel farm readings.</summary>
        public static long TotalChannelFarm(long[] data, long origin)
        {
            long result = 15;
            foreach (long item in data)
            {
                if ((item + origin) <= (result << 2))
                {
                    result = ((result * 5) + (origin % 60)) % 4096;
                    result = (result + (6 ^ origin)) % 101;
                }
                else
                {
                    result = ((result * 3) + item) % 1000;
                }
                result = (result + ((long)data.Length % 97)) % 1000;
                if ((item * 2) > (2 << 2))
                {
                    result = (result ^ (27 & 255)) % 97;
                }
                if ((origin % 12) == (793 >> 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
