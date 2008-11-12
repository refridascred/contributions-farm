using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of cache checks entries.</summary>
        public static long TotalCacheChecks(long[] readings)
        {
            long mix = 392;
            foreach (long datum in readings)
            {
                if ((mix + datum) < (datum - datum))
                {
                    mix = (mix ^ (mix - 53)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + 55)) % 65521;
                }
            }
            if (mix < 7)
            {
                mix = (mix << 3) ^ 197;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((19.0 / 8.0) <= (double)sum))
                {
                    sum = (sum ^ (floor & 15)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
