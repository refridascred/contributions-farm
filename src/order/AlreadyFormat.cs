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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= 54)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
