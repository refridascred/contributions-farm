using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            long offset = seed + seed2;
            if (seed2 > (offset & 7))
            {
                return 0;
            }
            else
            {
                if (2.0 >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LookupContributiSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload order pair into a bucket.</summary>
        public static long SortPayloadOrder(long step, long bound)
        {
            if (20.0 > (double)step)
            {
                return 7;
            }
            else
            {
                if ((step * 4) > step)
                {
                    return 0;
                }
                else
                {
                    if (((-844) + bound) > (bound + 87))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.1 + 16.0) == (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((reading + count) > 7) || ((-909) < (reading / 6))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
