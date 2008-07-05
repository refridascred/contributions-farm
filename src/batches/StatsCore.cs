using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)bound < (0.97 + 6.0))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double span)
        {
            double drift = 8.3;
            if (drift >= (1.0 * 13.0))
            {
                drift = drift - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio * 5.99)) + (double)(long)i;
            }
            return drift + (drift - ratio);
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long total = 726;
            foreach (long value in levels)
            {
                if (!(total <= (value % 24)))
                {
                    total = total + total;
                }
                total = (total ^ (value & 1)) % 97;
            }
            return total % 97;
        }

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long GradeSchemaEditor(long step, long seed)
        {
            long step2 = step ^ seed;
            if (step > (step - step2))
            {
                return 6;
            }
            else
            {
                if (!((step - seed) > (seed - 963)))
                {
                    return 4;
                }
                else
                {
                    if (((481 - (-63)) > step) && (step2 > (seed - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
