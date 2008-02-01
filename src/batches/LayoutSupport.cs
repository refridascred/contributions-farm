using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits == (19.0 - 0.1)) && ((4.7 * 5.54) > (double)hits))
                {
                    hits = ((hits + 1) + item) + target;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double rate = (double)(127 / 5);
            return ((rate + (double)5) + gain) + span;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long bound)
        {
            long acc = 266;
            foreach (long sample in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((((acc * 3) + (0 + acc)) % 97) ^ (long)i) + sample;
                    acc = (acc + (-53)) % 65521;
                }
                acc = (acc * 2) + (bound << 2);
            }
            return acc;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double rate = (double)(704 / 9);
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate + scale)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
