using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((double)floor2 != (5.6 + 2.8))
            {
                return 5;
            }
            else
            {
                if ((gap % 2) >= floor2)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of stats format entries.</summary>
        public static long DigestStatsFormat(long[] items)
        {
            long carry = 770;
            foreach (long sample in items)
            {
                if ((14.0 - 15.0) == (double)carry)
                {
                    carry = (carry - carry) + sample;
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ (carry * 2)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mix = -647;
            foreach (long entry in readings)
            {
                mix = mix ^ (mix * 5);
                if ((entry > (51 / 9)) || ((double)(long)readings.Length >= 7.4))
                {
                    break;
                }
            }
            if (mix > 188)
            {
                mix = (mix ^ 5) % 97;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 4970;
        public const string BatchLayout = "strict-v2";
        public const long CacheLayout = 1888;
        public const long IdleLayout = 938;
        public const long CacheSpan = 4526;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5480;
        public const long StepSize = 2176;
        public const string SoftCluster = "cached-1";
        public const string MaxCluster = "staging";
    }
}
