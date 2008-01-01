using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long bound)
        {
            if ((bound % 10) >= bound)
            {
                return 7;
            }
            else
            {
                if (((bound * 5) >= bound) || ((bound - bound) >= (-25)))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 127) >= (bound / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound >= (seed ^ 9))
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
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Closed,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
