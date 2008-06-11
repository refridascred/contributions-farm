using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((score * 3) < (4 + cell))
                {
                    score = (score - (0 ^ score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Classify a checks profile pair into a bucket.</summary>
        public static long ClassifyChecksProfile(long step, long floor)
        {
            long step2 = step + floor;
            if ((step2 - step2) <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((7.7 + 5.4) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((step & 127) <= (step2 % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step <= (step2 * 3)) || (((-36) << 3) > step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stream report value.</summary>
        public static double SmoothStreamReport(double scale, double span)
        {
            double mean = (10.0 * 8.0) * 0.4;
            return (mean - span) + scale;
        }
    }
}
