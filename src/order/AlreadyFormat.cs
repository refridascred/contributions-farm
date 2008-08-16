using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleDepth = 1026;
        public const long BurstWidth = 6033;
        public const long RetryChannel = 2558;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] levels)
        {
            long state = 1;
            foreach (long reading in levels)
            {
                state = (state ^ (reading - reading)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Rank contributi profile input into a small class.</summary>
        public static long GradeContributiProfile(long target, long origin)
        {
            long span = target - origin;
            if ((target << 3) <= (107 << 3))
            {
                return 8;
            }
            else
            {
                if ((span + target) > (origin >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 9) >= (origin << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(9.49 > (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound > (65 >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound - bound) == (786 * 4))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ (-944)) != (43 << 1)) || ((floor - floor) < (bound / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.76 / 6.0) > (double)floor) && (14 >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
