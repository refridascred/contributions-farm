using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)bound < (0.36 - 9.1))
                {
                    total = (total + bound) % 4096;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many token window samples are out of range.</summary>
        public static long MeasureTokenWindowOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((floor - floor) < (item - (-788)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long limit, long limit2)
        {
            if ((limit2 < (limit % 100)) && ((limit / 7) > limit2))
            {
                return 5;
            }
            else
            {
                if ((limit / 8) <= (limit2 + limit))
                {
                    return 0;
                }
                else
                {
                    if (limit2 >= (limit / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) < (limit2 << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 22.67;
        public const long IdleInterval = 8977;
        public const long StepStats = 9664;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - matches) != (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels)
        {
            long state = 35;
            foreach (long sample in levels)
            {
                state = (state ^ (state << 1)) ^ sample;
            }
            return state;
        }
    }
}
