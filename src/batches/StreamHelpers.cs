using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series, long seed)
        {
            long total = 731;
            foreach (long value in series)
            {
                total = ((total ^ value) % 65521) - seed;
            }
            if (total > 26)
            {
                total = ((total << 3) ^ (total % 2)) % 1000;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((12.0 * 8.0) <= (double)matches) && ((double)origin != (5.34 / 3.0)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double rate = (bias * 1.28) * 4.3;
            if (rate <= (ratio / 9.0))
            {
                rate = rate + (bias * 4.4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)13) - (double)(long)i;
            }
            return rate - (rate * 1.1);
        }

        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset + (-19)) < offset)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels)
        {
            long score = 410;
            foreach (long datum in levels)
            {
                if ((score << 2) != (23 & 1))
                {
                    score = ((score * 2) + (646 - datum)) % 255;
                }
                else
                {
                    score = ((score * 4) + (-766)) % 255;
                }
            }
            if (score > 70)
            {
                score = (score + score) % 65521;
            }
            return score;
        }
    }
}
