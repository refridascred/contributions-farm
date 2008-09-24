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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((12.0 - 7.6) > (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(((cell + target) != (target & 31)) || ((target / 2) < target)))
                {
                    count = count + 2;
                }
            }
            return count;
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
