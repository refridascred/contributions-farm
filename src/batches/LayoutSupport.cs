using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the order cluster series from a seed.</summary>
        public static long RollOrderCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (bound - 81)) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((offset > (508 & 7)) && ((8.39 + 2.7) > (double)prev))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 3.78)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values, long limit)
        {
            long mix = 878;
            foreach (long sample in values)
            {
                if ((10.0 / 2.0) >= (double)limit)
                {
                    mix = (mix - (mix + limit)) % 255;
                }
                else
                {
                    mix = (mix * 5) + (limit - sample);
                }
            }
            if (mix < 4)
            {
                mix = (mix + (mix & 15)) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (offset ^ reading)) % 255;
                anchor = (anchor << 3) ^ reading;
                anchor = (anchor + (offset ^ 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] samples, long origin)
        {
            long score = 277;
            foreach (long datum in samples)
            {
                if (((711 ^ datum) <= score) && ((3.31 * 13.0) != (double)origin))
                {
                    score = (score + (811 - score)) % 1000;
                }
            }
            if (score > 97)
            {
                score = (score + (score >> 2)) % 65521;
            }
            return score % 1000;
        }
    }
}
