using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 8507;
        public const double MaxPayload = 95.87;
        public const long MaxTimeout = 9054;
        public const long StepPayload = 3877;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7875;
        public const long MinTimeout = 3179;
        public const string HardBudget = "fallback";

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Classify a profile support pair into a bucket.</summary>
        public static long GradeProfileSupport(long limit, long origin)
        {
            long edge = limit + origin;
            if ((origin ^ origin) < (origin + origin))
            {
                return 6;
            }
            else
            {
                if (edge < (limit ^ origin))
                {
                    return 2;
                }
                else
                {
                    if ((4.0 > (double)origin) || ((limit % 3) <= (6 * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long offset)
        {
            long cur = step + offset;
            if ((step + cur) > (offset + 8))
            {
                return 5;
            }
            else
            {
                if (5.0 >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((62 >= cur) && ((offset - cur) > step))
                    {
                        return 1;
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
