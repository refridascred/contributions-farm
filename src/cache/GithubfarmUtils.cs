using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ (offset + carry)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record format entries.</summary>
        public static long CombineRecordFormat(long[] readings)
        {
            long mix = 557;
            foreach (long entry in readings)
            {
                mix = ((mix ^ (long)readings.Length) % 4096) - entry;
            }
            return mix % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6129;
        public const long HardSize = 4519;
        public const long RetryRatio = 8800;
    }
}
