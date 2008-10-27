using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double drift = 2.7 + (bias - bias);
            if (drift >= span)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 4.27) + (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + (long)series.Length) == (count % 8))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings, long target)
        {
            long mix = 631;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + (mix + mix)) % 4096;
                if (!((target ^ item) < target))
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 3) + (mix % 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Dropped,
            Synced,
        }
    }
}
