using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long CombineToolsGithubfarm(long[] data, long step)
        {
            long mix = 184;
            foreach (long sample in data)
            {
                mix = (((mix << 2) ^ (mix + sample)) % 255) + step;
            }
            if (mix < 801)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if (floor < (floor << 1))
            {
                return 5;
            }
            else
            {
                if ((floor < (bound % 24)) || ((bound - bound) <= (floor >> 1)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (bound + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((35 >> 1) != ((long)levels.Length - sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long limit)
        {
            if (((offset << 1) >= (8 - offset)) && ((8 & 7) > (limit << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (0.45 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset >> 4) != (407 << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long offset)
        {
            long span = floor - offset;
            if ((9.77 <= (double)floor) && (span < (605 / 7)))
            {
                return 0;
            }
            else
            {
                if ((offset * 2) < 7)
                {
                    return 2;
                }
                else
                {
                    if (((offset << 1) > floor) || ((floor ^ offset) <= (floor / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 * 4) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
