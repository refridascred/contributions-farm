using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((7.5 - 8.5) >= (double)item)
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardInterval = "legacy-1";
        public const long CacheFactor = 8916;
        public const string IdleToken = "latest";
    }
}
