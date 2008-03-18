using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the session context entries that pass the check.</summary>
        public static long CountSessionContextHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)405 < (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double mean = (double)(61 - 21);
            if (mean < 7.2)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean + (double)88;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double bias = offset;
            if (bias <= offset)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (offset + 3.7)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "stable-edge";
        public const long LimitCache = 8215;
        public const double LimitWidth = 69.07;
        public const double WindowCache = 69.16;

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long CountMetricFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches % 12) > (datum - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long step)
        {
            long bound = target ^ step;
            if ((step - bound) != (bound - bound))
            {
                return 8;
            }
            else
            {
                if (((bound + target) <= (step & 127)) || ((step + 35) >= step))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 4) == (591 & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target - bound) <= (588 >> 3)) || ((bound + target) <= (target - 9)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
