using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report editor readings.</summary>
        public static long TallyReportEditor(long[] samples, long offset)
        {
            long carry = 69;
            foreach (long cell in samples)
            {
                carry = ((carry + (5 / 5)) % 101) + cell;
            }
            if (carry < (-937))
            {
                carry = (carry + (0 ^ offset)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinWidth = 4069;
        public const long StepGraph = 8252;
        public const long CacheDepth = 3967;
        public const double StepInterval = 14.67;

        /// <summary>Count window context pairs that satisfy a relation.</summary>
        public static long OverlapWindowContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
