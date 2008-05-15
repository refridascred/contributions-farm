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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Retry,
            Synced,
            New,
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
