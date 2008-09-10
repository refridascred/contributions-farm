using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinCount = 7333;
        public const string CacheSize = "cached-1";
        public const long IdleToken = 3201;
        public const string BurstSize = "strict";

        /// <summary>Classify a entry editor pair into a bucket.</summary>
        public static long ClassifyEntryEditor(long floor, long step)
        {
            if ((7 > floor) && ((double)step > (6.0 * 5.1)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > (15.0 / 9.0))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor < (12.0 + 7.2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (step >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long bound)
        {
            if (target > (bound % 24))
            {
                return 6;
            }
            else
            {
                if ((target * 3) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((target >> 4) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
