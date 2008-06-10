using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1896;
        public const string BatchContext = "open";
        public const long CacheContext = 3906;
        public const long DefaultContext = 4895;
        public const double RetryContext = 57.96;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long limit)
        {
            long prev = floor + limit;
            if (floor > limit)
            {
                return 8;
            }
            else
            {
                if ((limit > (floor + prev)) || (9.8 >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)prev <= (double)98)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit + prev) != (677 << 1)) || (((-41) + limit) <= limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long RankBufferCluster(long floor, long bound)
        {
            long diff = floor ^ bound;
            if ((double)diff != (17.0 + 4.0))
            {
                return 8;
            }
            else
            {
                if ((diff + diff) == (diff & 7))
                {
                    return 6;
                }
                else
                {
                    if (((8.0 * 6.0) >= (double)bound) && ((201 - diff) != (bound + 106)))
                    {
                        return 7;
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
