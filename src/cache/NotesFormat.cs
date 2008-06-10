using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if (((sample - sample) >= (long)data.Length) || ((double)mix > 14.0))
                {
                    mix = ((mix << 2) ^ (6 + 521)) % 4096;
                }
            }
            return mix % 97;
        }

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
