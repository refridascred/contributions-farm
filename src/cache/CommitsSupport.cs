using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((hits / 3) <= step))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "staging-v2";
        public const long SoftSpan = 6703;
        public const string MinBudget = "local-v2";
        public const double DefaultSchema = 15.19;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultWidth = 1938;
        public const long IdleSize = 7002;
        public const long WindowTimeout = 8036;
        public const long BatchEntry = 6907;
        public const long BatchDepth = 7133;

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a account profile value against two limits.</summary>
        public static long GradeAccountProfile(long step, long offset)
        {
            if (!((offset + 2) == (offset % 5)))
            {
                return 6;
            }
            else
            {
                if (((double)offset != (7.73 + 0.25)) && ((double)offset <= 5.5))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }
    }
}
