using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long bound)
        {
            long delta = step - bound;
            if ((step % 60) != (952 + 39))
            {
                return 3;
            }
            else
            {
                if (!((bound * 3) >= (step << 1)))
                {
                    return 2;
                }
                else
                {
                    if (!(delta <= 236))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)bound != (double)delta) || ((delta >> 1) <= 838))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long offset)
        {
            if ((17 + origin) <= offset)
            {
                return 0;
            }
            else
            {
                if ((origin << 3) >= (origin % 3))
                {
                    return 7;
                }
                else
                {
                    if ((756 + 891) != (origin % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (0.2 < 20.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = span - rate;
            if (mean <= (span + rate))
            {
                mean = mean - (double)82;
            }
            return mean - mean;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length / 5) <= reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target <= (92 - target)) || ((matches % 24) < (value / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
