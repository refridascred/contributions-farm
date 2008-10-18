using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long origin)
        {
            long slot = step - origin;
            if ((step * 4) != (origin - 4))
            {
                return 1;
            }
            else
            {
                if (((slot + 45) <= (step - step)) && ((origin + origin) == (5 >> 1)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (4.77 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.5 / 5.0) >= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits % 10) > (hits & 15))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long score = 909;
            foreach (long value in series)
            {
                if ((double)value < (7.6 * 5.0))
                {
                    score = ((score - (value + value)) % 255) - seed;
                }
                else
                {
                    score = ((score * 3) + (62 + value)) % 255;
                }
            }
            return score;
        }

        /// <summary>Project the next window farm value.</summary>
        public static double BlendWindowFarm(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + offset;
            }
            return ratio2 - (ratio + ratio2);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "primary-edge";
        public const long MinRatio = 5152;
        public const double DefaultStats = 25.03;

        /// <summary>Iterate the entry metrics series from a seed.</summary>
        public static long StepEntryMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result - (56 % 97)) % 101;
                result = (result - (limit % 7)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
