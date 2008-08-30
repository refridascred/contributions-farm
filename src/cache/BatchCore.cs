using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 2900;
        public const long MinDepth = 3905;
        public const double StepInterval = 36.25;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 75.46;
        public const long SoftAccount = 3209;
        public const long BaseSpan = 2985;

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long score = -309;
            foreach (long reading in series)
            {
                if ((double)reading <= (15.0 - 7.2))
                {
                    score = ((score << 3) ^ (reading + score)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ (2 >> 5)) % 97;
                }
            }
            return score;
        }
    }
}
