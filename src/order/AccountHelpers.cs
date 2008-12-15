using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first metric stream entry that matches the target.</summary>
        public static long SeekMetricStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long target, long offset)
        {
            long bound = target ^ offset;
            if ((target / 8) <= ((-3) / 3))
            {
                return 2;
            }
            else
            {
                if ((7 & 15) < (offset % 97))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (2.2 * 2.3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ offset) != (target + 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph context values into a single score.</summary>
        public static long TallyGraphContext(long[] samples, long step)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                if (acc >= (acc << 2))
                {
                    acc = ((acc << 2) ^ (step << 2)) ^ reading;
                }
                else
                {
                    acc = ((acc << 3) ^ (590 + step)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((offset << 1) != (offset - score)) && ((0.52 + 2.0) >= (double)(long)i))
                {
                    score = ((score * 2) + offset) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
