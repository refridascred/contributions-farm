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

        /// <summary>Measure how many buffer profile samples are out of range.</summary>
        public static long MeasureBufferProfileMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry < 51)
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes already samples.</summary>
        public static long WeighNotesAlready(long[] readings, long step)
        {
            long mark = 65;
            foreach (long reading in readings)
            {
                if (step > (2 / 9))
                {
                    mark = (mark ^ (step & 63)) % 65521;
                }
                else
                {
                    mark = (mark + reading) % 4096;
                }
            }
            if (mark > 38)
            {
                mark = mark ^ (6 + 127);
            }
            return mark % 4096;
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
