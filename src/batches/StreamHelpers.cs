using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long sum = 27;
            foreach (long entry in data)
            {
                if ((bound + bound) < (bound % 2))
                {
                    sum = ((sum * 4) + (144 / 3)) ^ entry;
                }
            }
            if (sum < 4)
            {
                sum = (sum - bound) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long SortRecordQueue(long target, long seed)
        {
            if ((9.62 - 5.0) == (double)seed)
            {
                return 2;
            }
            else
            {
                if (seed <= (seed / 6))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((884 % 10) != (origin + origin))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            if (!((8.83 + 8.7) != (double)offset))
            {
                return 3;
            }
            else
            {
                if ((offset2 ^ 62) >= offset)
                {
                    return 7;
                }
                else
                {
                    if (((double)offset != (4.5 * 0.3)) && ((offset ^ offset) > (offset2 + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((86 - offset) != (offset & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor metric readings against a bound.</summary>
        public static bool VerifyEditorMetricRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
