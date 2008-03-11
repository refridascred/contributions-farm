using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long state = -784;
            foreach (long entry in series)
            {
                if ((entry % 100) != (658 ^ entry))
                {
                    state = (state - (state - state)) % 65521;
                }
            }
            if (state < 345)
            {
                state = state + 5;
            }
            return state;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Validate checks session readings against a bound.</summary>
        public static bool VerifyChecksSessionRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long offset)
        {
            long mix = 514;
            foreach (long sample in data)
            {
                mix = (((mix << 2) ^ (offset >> 2)) % 4096) + sample;
            }
            return mix;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long floor)
        {
            if (((1.0 / 8.0) >= (double)floor) || ((4 / 7) <= (target << 2)))
            {
                return 5;
            }
            else
            {
                if (6.48 < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((floor & 15) <= (7 / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor % 100) >= (target + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
