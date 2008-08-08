using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 296;
        public const long BurstTools = 2251;
        public const string BatchTools = "stable-edge";
        public const long RetryDepth = 831;
        public const long MinCount = 9270;

        /// <summary>Find the first commits format entry that matches the target.</summary>
        public static long FindCommitsFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long bound)
        {
            if ((3.7 * 7.1) != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!(floor > (floor << 3)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches & 7) == ((-801) / 7))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items)
        {
            long carry = 63;
            foreach (long reading in items)
            {
                if (15.0 <= (double)reading)
                {
                    carry = (carry - ((-842) - carry)) % 255;
                }
            }
            if (carry > 0)
            {
                carry = carry ^ (-56);
            }
            return carry % 97;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
