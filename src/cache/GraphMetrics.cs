using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long floor)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                if (!(entry < (entry & 3)))
                {
                    anchor = ((anchor ^ (entry >> 5)) % 65521) - floor;
                }
                if ((entry ^ entry) >= anchor)
                {
                    anchor = anchor ^ (816 * 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ entry) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double rate = bias - 14.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long step)
        {
            if ((step % 2) < offset)
            {
                return 3;
            }
            else
            {
                if (step > ((-4) + step))
                {
                    return 0;
                }
                else
                {
                    if (offset > (step ^ 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((12.0 / 7.0) <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item / 6) <= (matches + 9)))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
