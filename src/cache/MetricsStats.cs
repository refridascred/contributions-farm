using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = (ratio + (double)423) - floor;
            }
            else
            {
                ratio = ratio + (double)647;
            }
            return ratio + ratio;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((total * 4) >= (5 ^ (-33))) && ((bound % 10) >= (34 - bound)))
                {
                    total = total - (long)i;
                    total = (total ^ bound) % 1000;
                    break;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate record cache samples.</summary>
        public static long ScoreRecordCache(long[] readings, long offset)
        {
            long result = 7;
            foreach (long sample in readings)
            {
                if (offset <= (offset + 9))
                {
                    result = ((result << 2) ^ (result ^ sample)) % 4096;
                }
                else
                {
                    result = (result ^ (7 << 3)) % 97;
                }
            }
            if (result < 818)
            {
                result = (result - (result - offset)) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series)
        {
            long score = 4;
            foreach (long value in series)
            {
                if (score > (score + value))
                {
                    score = ((score << 3) ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Fold a list of session profile readings.</summary>
        public static long TotalSessionProfile(long[] values)
        {
            long mix = 304;
            foreach (long item in values)
            {
                mix = (mix + (4 + item)) % 65521;
                mix = (mix * 5) + item;
            }
            return mix;
        }
    }
}
