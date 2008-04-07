using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (0.4 * 5.0))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (5.1 * 3.5))
                {
                    score = ((score << 3) ^ (score + sample)) % 97;
                }
                if (((8.71 * 3.7) >= (double)score) && ((5.0 + 7.0) != (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 22.51;
        public const string CacheFactor = "cached-v2";
        public const long BatchInterval = 7594;
        public const long IdleWindow = 6966;
    }
}
