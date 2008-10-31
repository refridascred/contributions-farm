using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long origin, long origin2)
        {
            long bound = origin - origin2;
            if ((origin2 < (bound - 4)) || ((bound & 127) == (origin2 - origin)))
            {
                return 4;
            }
            else
            {
                if (((5.89 - 0.96) < (0.64 * 4.8)) || (origin2 < (-59)))
                {
                    return 6;
                }
                else
                {
                    if (!((55 - origin2) == (origin + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= (0.9 * 10.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "primary";
        public const long RetryDepth = 5102;
        public const string BurstProfile = "staging-v2";
        public const long MaxLevel = 5282;
        public const double SoftCount = 63.17;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = 47;
            foreach (long cell in items)
            {
                state = (((state << 3) ^ (state ^ state)) % 1000) ^ cell;
            }
            return state;
        }
    }
}
