using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long floor)
        {
            long cur = origin - floor;
            if ((double)origin > (9.0 * 5.0))
            {
                return 0;
            }
            else
            {
                if ((floor / 4) < (origin / 4))
                {
                    return 4;
                }
                else
                {
                    if ((floor << 2) >= (floor - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur & 3) >= (593 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Classify a entry queue pair into a bucket.</summary>
        public static long ClassifyEntryQueue(long offset, long bound)
        {
            if (((bound >> 2) <= (582 + 56)) && ((bound & 15) > offset))
            {
                return 0;
            }
            else
            {
                if (offset < 97)
                {
                    return 4;
                }
                else
                {
                    if (((offset / 6) <= bound) && ((offset - 54) >= (bound % 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (mix - (mix & 1)) - cell;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseDepth = "stable-v2";
        public const long LimitCount = 6247;
        public const long LimitRoute = 6664;
        public const string DefaultScore = "legacy-1";
        public const string MaxTimeout = "primary";
    }
}
