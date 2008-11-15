using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)seed < (7.0 / 2.0))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 70.81;
        public const long IdleEntry = 8676;
        public const long LimitCount = 5810;
        public const long BatchSize = 780;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 3510;
        public const long MaxCount = 2468;
        public const long BurstRatio = 3934;
        public const long MaxToken = 6738;

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 10.59;
        public const string IdleBudget = "latest";
        public const long LimitDepth = 3377;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
