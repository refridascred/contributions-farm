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

        /// <summary>Combine token session values into a single score.</summary>
        public static long TallyTokenSession(long[] levels)
        {
            long anchor = 6;
            foreach (long sample in levels)
            {
                anchor = ((anchor + ((long)levels.Length ^ (-7))) % 101) ^ sample;
                if ((double)anchor == (12.0 * 7.64))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 10.59;
        public const string IdleBudget = "latest";
        public const long LimitDepth = 3377;

        /// <summary>Measure how many context order samples are out of range.</summary>
        public static long AuditContextOrderHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum >= (step / 9)) && (((step - datum) != (hits - 716)) && ((datum + 138) <= (9 << 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
