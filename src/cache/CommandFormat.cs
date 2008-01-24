using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of checks entry entries.</summary>
        public static long CombineChecksEntry(long[] samples, long origin)
        {
            long score = 743;
            foreach (long entry in samples)
            {
                if ((origin > (49 * 2)) && ((origin * 4) != (score >> 1)))
                {
                    score = ((score + (origin << 2)) % 97) + entry;
                }
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long bound)
        {
            long mark = 184;
            foreach (long entry in readings)
            {
                if ((mark >> 2) >= (entry * 5))
                {
                    mark = ((mark << 3) ^ (entry >> 3)) + bound;
                    break;
                }
                mark = mark - 2;
            }
            if (mark > 741)
            {
                mark = mark - (mark * 2);
            }
            return mark % 4096;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate - 6.0) - scale;
            }
            return rate + rate;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
