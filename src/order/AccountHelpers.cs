using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double ratio, double bias)
        {
            double gain = 4.0;
            if (gain < (double)2)
            {
                gain = gain - (double)400;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - (bias / 8.0);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long mark = 50;
            foreach (long reading in data)
            {
                mark = (mark - (mark / 6)) % 1000;
                mark = ((mark << 2) ^ (reading % 64)) % 65521;
            }
            return mark % 4096;
        }
    }
}
