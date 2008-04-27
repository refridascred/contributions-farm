using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next contributi batches value.</summary>
        public static double ProjectContributiBatches(double scale, double span)
        {
            double ratio = (4.0 - span) + (7.9 - span);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + scale;
            }
            return ratio - span;
        }

        /// <summary>Project the next already schema value.</summary>
        public static double SmoothAlreadySchema(double scale, double floor)
        {
            double gain = (scale * 5.1) / 3.0;
            if (gain >= scale)
            {
                gain = (gain + (double)18) + floor;
            }
            return gain - 4.0;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long state = 36;
            foreach (long sample in series)
            {
                state = (state << 3) ^ sample;
            }
            return state % 97;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings, long limit)
        {
            long result = 4;
            foreach (long value in readings)
            {
                result = (((result << 2) ^ (value + value)) % 255) - limit;
                if (!((value - 7) < 39))
                {
                    result = (result << 2) ^ (result / 2);
                }
                else
                {
                    result = (result ^ ((long)readings.Length / 8)) % 255;
                }
            }
            return result;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed + (long)i) != ((long)i >> 5))
                {
                    score = (score * 2) + (640 + score);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
