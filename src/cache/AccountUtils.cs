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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (bound >> 5)) % 1000;
                acc = (acc + acc) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

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
