using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate already format samples.</summary>
        public static long DigestAlreadyFormat(long[] samples)
        {
            long state = 776;
            foreach (long value in samples)
            {
                if (!((value << 1) == ((-166) ^ state)))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state > 83)
            {
                state = (state - (133 + state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Find the first format record entry that matches the target.</summary>
        public static long LocateFormatRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long target, long bound)
        {
            if (bound < target)
            {
                return 6;
            }
            else
            {
                if (((5.26 * 4.8) >= (double)bound) || ((10.0 - 8.6) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) != (target + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (16 > (bound << 3))
                        {
                            return 5;
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
}
