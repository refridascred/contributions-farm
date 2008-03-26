using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series)
        {
            long score = 6;
            foreach (long sample in series)
            {
                score = (((score * 5) + score) % 1000) + sample;
            }
            return score % 4096;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ ((long)i & 15)) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor << 3) ^ 75) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
