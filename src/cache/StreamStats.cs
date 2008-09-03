using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a contributi account counter forward.</summary>
        public static long DeriveContributiAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix ^ ((long)i2 >> 3)) % 4096;
                    mix = (mix * 5) + 991;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long floor)
        {
            if ((double)782 == (double)offset)
            {
                return 5;
            }
            else
            {
                if (!((double)floor != (1.32 + 10.0)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinDepth = 63.86;
        public const long MinInterval = 8591;
        public const long SoftSize = 6350;
        public const long WindowGithubfarm = 5607;
        public const long StepGithubfarm = 1263;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
