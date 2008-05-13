using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a session contributi figure with a bias.</summary>
        public static double ScaleSessionContributi(double weight, double offset)
        {
            double mean = 4.52;
            if (mean > (offset / 6.0))
            {
                mean = (mean - (double)(-14)) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - (double)940;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 4) + (6 * 4)) % 65521) ^ (long)i2;
                }
                if ((long)i < (mix >> 3))
                {
                    mix = (mix ^ (long)i) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of contributi record entries.</summary>
        public static long CombineContributiRecord(long[] items, long bound)
        {
            long result = 63;
            foreach (long item in items)
            {
                if (bound < (bound + result))
                {
                    result = ((result * 3) + item) % 97;
                }
            }
            if (result < 8)
            {
                result = (result - (6 - bound)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Dropped,
            Stale,
            New,
        }
    }
}
