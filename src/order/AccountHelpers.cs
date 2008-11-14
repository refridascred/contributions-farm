using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a editor checks value against two limits.</summary>
        public static long RankEditorChecks(long limit, long seed)
        {
            long gap = limit + seed;
            if (((7.77 * 2.5) <= (double)limit) && ((13.0 + 5.8) < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((gap <= (seed & 255)) && (gap >= (gap + gap)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed != (double)56)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((632 + 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Draft,
            Active,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstInterval = 52.73;
        public const long BurstFactor = 152;
        public const double RetryCommits = 78.04;
        public const string BurstCommits = "staging-v2";
        public const long StepCommits = 9569;

        /// <summary>Digest a series of buffer tools entries.</summary>
        public static long DigestBufferTools(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (total + (cell + total)) % 1000;
                if ((total << 1) > ((long)items.Length + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 8016;
        public const long IdleDepth = 4360;
        public const double RetryStream = 52.89;
    }
}
