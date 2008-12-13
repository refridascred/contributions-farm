using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool GuardEntryPayloadBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up commits graph samples.</summary>
        public static long OverlapCommitsGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long floor)
        {
            long acc = 54;
            foreach (long item in series)
            {
                if ((double)item < (5.7 / 6.0))
                {
                    acc = (acc + floor) % 101;
                }
                else
                {
                    acc = (acc ^ (item + acc)) % 1000;
                }
            }
            if (acc > (-274))
            {
                acc = ((acc * 5) + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long step)
        {
            if ((double)step > (2.0 - 9.77))
            {
                return 3;
            }
            else
            {
                if ((1.0 + 4.51) == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (limit > (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
