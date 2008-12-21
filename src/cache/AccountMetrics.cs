using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 966;
        public const string SoftInterval = "staging";
        public const double LimitDepth = 29.28;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema layout input into a small class.</summary>
        public static long BucketSchemaLayout(long floor, long offset)
        {
            long cur = floor ^ offset;
            if (10 >= (floor % 97))
            {
                return 5;
            }
            else
            {
                if ((cur + cur) >= cur)
                {
                    return 6;
                }
                else
                {
                    if ((cur + 445) > (889 % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "local-v2";
        public const string BatchSize = "legacy-1";
        public const long DefaultEditor = 1410;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
