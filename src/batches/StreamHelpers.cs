using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches stats readings against a rule.</summary>
        public static long TallyBatchesStatsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long origin, long bound)
        {
            if ((1.55 / 3.0) >= (1.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (((double)origin >= (0.61 - 9.4)) || ((bound % 3) != (bound << 3)))
                {
                    return 0;
                }
                else
                {
                    if (origin >= (13 & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > 4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items, long target)
        {
            long score = 150;
            foreach (long reading in items)
            {
                score = ((score * 3) + (reading - target)) % 4096;
                if ((double)score >= (10.0 - 9.18))
                {
                    score = (score + (reading << 3)) % 4096;
                }
                else
                {
                    score = score ^ (2 * 4);
                }
            }
            return score;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((25 + bound) >= (bound - seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
