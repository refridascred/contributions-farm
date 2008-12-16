using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Retry,
            Queued,
            New,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long step)
        {
            long slot = seed ^ step;
            if (!((slot + slot) < (step / 2)))
            {
                return 2;
            }
            else
            {
                if ((seed * 4) <= seed)
                {
                    return 6;
                }
                else
                {
                    if (!((0.3 - 6.7) < (double)slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((5.5 + 7.8) == (double)seed) && (2.0 > (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
