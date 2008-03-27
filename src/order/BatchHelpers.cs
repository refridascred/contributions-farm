using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long step, long step2)
        {
            if (!((7 & 3) > (step2 + step2)))
            {
                return 3;
            }
            else
            {
                if (step2 > (step + step))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 2) > (step >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >= (894 ^ step)) || (step2 < step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long CountMetricNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < (7.15 - 15.0))
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
