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

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowInterval = 6339;
        public const long LimitCount = 9886;
        public const long BaseStream = 9506;
        public const long DefaultStream = 3787;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values, long floor)
        {
            long score = 4;
            foreach (long value in values)
            {
                if (((79 ^ (long)values.Length) == (value * 5)) || (score <= (score + 477)))
                {
                    score = (score - score) % 65521;
                }
                else
                {
                    score = ((score * 4) + (70 / 6)) % 1000;
                }
            }
            if (score < 7)
            {
                score = (score - (score ^ floor)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Stale,
            Active,
            Done,
        }
    }
}
