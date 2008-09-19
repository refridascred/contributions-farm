using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 582;
        public const long IdleSession = 9633;
        public const string BaseSession = "cached";
        public const string HardFactor = "strict";
        public const long DefaultSession = 34;

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 3) ^ cell) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long offset)
        {
            if (offset >= (92 % 3))
            {
                return 4;
            }
            else
            {
                if ((double)target == (9.8 + 4.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ bound;
                if (carry >= (bound - carry))
                {
                    carry = (carry + (968 << 2)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long origin)
        {
            long score = 24;
            foreach (long datum in readings)
            {
                if ((datum << 2) > (score >> 3))
                {
                    score = (score << 3) ^ (origin - score);
                }
            }
            return score % 4096;
        }
    }
}
