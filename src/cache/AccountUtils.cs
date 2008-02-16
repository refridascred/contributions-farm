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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix << 2) ^ (mix & 31);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
