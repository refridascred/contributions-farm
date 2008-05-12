using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long bound)
        {
            long lane = target - bound;
            if ((double)lane >= (3.0 * 8.93))
            {
                return 1;
            }
            else
            {
                if (((target + 4) < target) && ((lane / 3) < lane))
                {
                    return 2;
                }
                else
                {
                    if (((double)target >= 16.0) || (target < 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if ((3.68 / 3.0) > (double)step)
                {
                    long prev = step - (799 ^ total);
                    total = ((total * 4) + (153 ^ prev)) % 65521;
                }
                else
                {
                    total = (total - 681) % 4096;
                    total = (total ^ (total - (long)i)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheBudget = 1827;
        public const long RetryContributi = 2175;
        public const long HardInterval = 3573;
        public const long BurstLevel = 2879;
        public const long LimitContributi = 6553;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((cell - cell) <= cell) && ((hits ^ 707) == (cell - 299)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc ^ origin) + (long)i;
                }
                if ((sample >> 3) == (sample + origin))
                {
                    acc = (acc ^ (45 >> 5)) % 97;
                }
                else
                {
                    acc = acc + (sample + origin);
                }
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
