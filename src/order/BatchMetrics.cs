using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 4065;
        public const double StepSpan = 16.75;
        public const double BaseQueue = 23.68;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long step)
        {
            long lane = origin - step;
            if (((origin / 9) <= (step + lane)) && ((step - origin) <= origin))
            {
                return 2;
            }
            else
            {
                if (645 <= (origin + 674))
                {
                    return 0;
                }
                else
                {
                    if ((9.0 / 2.0) == (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels)
        {
            long acc = -61;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.61 / 8.0))
                {
                    acc = (acc ^ (cell << 2)) % 65521;
                    continue;
                }
                if (acc > (cell - cell))
                {
                    acc = (acc - cell) % 255;
                }
                else
                {
                    acc = (acc + (cell / 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items)
        {
            long sum = 569;
            foreach (long value in items)
            {
                long matches = sum;
                if ((value % 10) == (matches >> 3))
                {
                    matches = (matches ^ (sum ^ matches)) % 97;
                }
                else
                {
                    matches = (matches + (sum ^ value)) % 255;
                }
                sum = (sum - (value * 4)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Validate editor route readings against a bound.</summary>
        public static bool ValidateEditorRouteRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
