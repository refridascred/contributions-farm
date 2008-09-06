using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] levels, long step)
        {
            long carry = 235;
            foreach (long datum in levels)
            {
                carry = ((carry + (step * 5)) % 1000) ^ datum;
                carry = (carry + (carry * 2)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 83.19;
        public const double SoftSchema = 87.67;
        public const long StepSchema = 2023;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long floor)
        {
            if (((floor << 3) < target) && ((floor << 3) <= (floor + 6)))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (3.0 + 7.0))
                {
                    return 1;
                }
                else
                {
                    if ((3.0 / 6.0) <= (1.89 * 2.9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((7.2 / 2.0) < (double)target))
                        {
                            return 3;
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
}
