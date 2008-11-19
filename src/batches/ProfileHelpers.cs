using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Ready,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (offset * 8.21)) + (double)(long)i;
            }
            return drift - (double)452;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] readings, long floor)
        {
            long mark = 7;
            foreach (long entry in readings)
            {
                mark = (mark - 6) % 65521;
                mark = (mark ^ (entry * 4)) % 255;
                if (!((entry - floor) <= mark))
                {
                    mark = mark ^ (entry >> 1);
                }
            }
            return mark;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Done,
            Idle,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
