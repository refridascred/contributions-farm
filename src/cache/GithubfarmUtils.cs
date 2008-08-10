using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session checks entries.</summary>
        public static long FoldSessionChecks(long[] levels)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (7 < (carry % 64))
                {
                    carry = (((carry * 5) + carry) % 97) + sample;
                }
                else
                {
                    carry = carry ^ 664;
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ (carry << 3)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long result = 940;
            foreach (long cell in series)
            {
                if (offset < cell)
                {
                    result = ((result * 4) + (result % 7)) % 97;
                }
                if (!((result - cell) == (cell + 782)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 1166;
        public const long BatchFormat = 8534;
        public const long SoftDepth = 3969;

        /// <summary>Classify a contributi notes pair into a bucket.</summary>
        public static long RankContributiNotes(long bound, long step)
        {
            if ((5 << 3) > (step ^ bound))
            {
                return 5;
            }
            else
            {
                if ((bound & 127) <= 734)
                {
                    return 1;
                }
                else
                {
                    if ((2 / 5) <= (bound - 0))
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
}
