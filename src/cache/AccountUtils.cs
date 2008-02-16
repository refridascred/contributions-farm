using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (tally + tally))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchTimeout = 8057;
        public const string DefaultSupport = "stable-1";
        public const long BaseSupport = 6480;

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long RollChecksEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = mix + mix;
                if ((4.5 * 6.7) <= (double)target)
                {
                    mix = (mix ^ (mix - target)) % 97;
                    mix = (mix << 3) ^ 69;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
