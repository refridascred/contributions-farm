using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double drift = (double)(8 << 2);
            return ((drift - drift) + scale) + bias;
        }

        /// <summary>Digest a series of commits account entries.</summary>
        public static long FoldCommitsAccount(long[] data, long bound)
        {
            long score = 77;
            foreach (long cell in data)
            {
                score = (score ^ (613 / 6)) % 101;
                if (!(bound >= cell))
                {
                    score = (score + (3 + 75)) % 255;
                }
                if ((bound / 6) < score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9.35 / 6.0) >= (double)matches)
                {
                    matches = ((matches + 3) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((6.0 - 5.0) == (double)(long)i)
                {
                    anchor = (anchor * 2) + (anchor / 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long offset2)
        {
            if ((offset2 + 973) != (offset2 % 100))
            {
                return 2;
            }
            else
            {
                if (offset2 > (offset - offset2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
