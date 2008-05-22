using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double rate, double span)
        {
            double rate2 = (double)7 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - span;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
