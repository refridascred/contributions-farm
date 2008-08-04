using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long step, long step2)
        {
            if ((step & 31) < (step2 + step2))
            {
                return 5;
            }
            else
            {
                if ((step2 + step) != (step >> 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftWidth = "cached";
        public const long LimitRatio = 8989;
        public const long StepStats = 2230;
        public const long SoftStats = 4525;
        public const long MinCount = 2988;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((limit >> 3) <= (seed - 4))
            {
                return 7;
            }
            else
            {
                if ((329 + limit) < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((hits + hits) >= hits) && (bound <= (cell % 3))) && ((cell - hits) < (hits << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Paused,
            Closed,
            Retry,
        }
    }
}
