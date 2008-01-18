using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + 60) > (item - 46))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1619;
        public const double WindowToken = 8.16;
        public const double MinDepth = 87.71;
        public const long MinSize = 7258;

        /// <summary>Audit stats token readings against a rule.</summary>
        public static long CountStatsTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample - sample) >= (tally / 6)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
