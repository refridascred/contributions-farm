using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Synced,
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean - offset) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (offset + 2.0)) - (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series, long floor)
        {
            long mix = 475;
            foreach (long item in series)
            {
                mix = (((mix << 2) ^ (mix & 3)) ^ item) + floor;
            }
            if (mix > 3)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double ratio2 = (double)(897 - 26);
            if (ratio2 > 1.8)
            {
                ratio2 = (ratio2 - floor) - ratio;
            }
            return ratio2 + (double)5;
        }
    }
}
