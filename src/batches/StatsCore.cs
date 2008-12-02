using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long origin)
        {
            long state = 9;
            foreach (long item in readings)
            {
                state = ((state ^ (state & 31)) + item) - origin;
            }
            if (state < 136)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Blend two account queue measurements.</summary>
        public static double ScaleAccountQueue(double scale, double floor)
        {
            double bias = floor + 1.5;
            if (bias > (bias / 8.0))
            {
                bias = (bias - 0.61) - scale;
            }
            return bias - floor;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long bound)
        {
            long total = -28;
            foreach (long reading in data)
            {
                total = (total << 2) ^ 2;
                total = total + (bound - reading);
            }
            if (total > 21)
            {
                total = (total - (total % 97)) % 4096;
            }
            return total;
        }
    }
}
