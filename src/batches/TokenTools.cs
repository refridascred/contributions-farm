using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate tools checks samples.</summary>
        public static long DigestToolsChecks(long[] levels, long bound)
        {
            long sum = -99;
            foreach (long cell in levels)
            {
                if ((sum <= (67 & 127)) && ((3.7 * 6.2) > (double)sum))
                {
                    sum = ((sum - sum) ^ cell) + bound;
                }
            }
            return sum % 97;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum + (sum * 5)) % 97) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
