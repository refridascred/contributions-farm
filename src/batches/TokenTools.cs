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

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings)
        {
            long mix = 86;
            foreach (long datum in readings)
            {
                if (!((double)mix < (double)datum))
                {
                    mix = ((mix << 2) ^ (mix * 2)) % 101;
                }
            }
            return mix;
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
