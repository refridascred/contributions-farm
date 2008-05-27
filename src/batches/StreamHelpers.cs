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

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long bound2)
        {
            if ((bound + bound2) >= (0 * 3))
            {
                return 0;
            }
            else
            {
                if (7.0 >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (bound >= (bound << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
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
