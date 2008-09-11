using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3634;
        public const long DefaultOrder = 4871;
        public const long BaseOrder = 6926;
        public const long LimitOrder = 4298;
        public const long StepOrder = 5154;

        /// <summary>Combine notes window values into a single score.</summary>
        public static long ScoreNotesWindow(long[] samples)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + (-71)) % 65521;
                if (((-368) / 6) != ((-31) - carry))
                {
                    carry = carry ^ (carry + entry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
