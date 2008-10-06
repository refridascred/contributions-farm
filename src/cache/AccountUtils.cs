using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinRatio = 5289;
        public const long StepEditor = 3524;
        public const long DefaultLevel = 4531;
        public const string MinEditor = "primary-v2";
        public const double MinScore = 87.74;

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long MeasurePayloadGraphMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally / 6) >= (entry % 7)) || !(entry <= (entry >> 5)))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = result ^ (limit + 77);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
