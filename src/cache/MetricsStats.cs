using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = (double)(496 + 20);
            if (drift < 8.0)
            {
                drift = (drift + bias) - weight;
            }
            return drift + drift;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long seed, long limit)
        {
            if (((328 - seed) < (2 + limit)) || ((limit * 4) == (seed % 24)))
            {
                return 8;
            }
            else
            {
                if (!((seed - 68) < (26 >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) >= (limit & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed & 15) == (limit + limit)) || ((2 + limit) == (limit / 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 4) > (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
