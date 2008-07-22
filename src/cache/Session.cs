using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long carry = 675;
            foreach (long cell in readings)
            {
                carry = (carry - (origin / 7)) ^ cell;
            }
            if (carry > 700)
            {
                carry = ((carry * 5) + (origin + carry)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > (ratio / 8.0))
            {
                ratio = (ratio + offset) - rate;
            }
            return ratio + 11.0;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane - step) >= (lane - bound))
            {
                return 8;
            }
            else
            {
                if ((step < lane) && ((lane + lane) >= (4 + bound)))
                {
                    return 2;
                }
                else
                {
                    if (((bound / 8) <= (bound + step)) || ((11.0 * 7.9) > (double)lane))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 47.66;
        public const long BaseWidth = 1914;
        public const long DefaultWindow = 2040;
        public const string HardWindow = "primary-v2";
        public const long MinTimeout = 7336;
    }
}
