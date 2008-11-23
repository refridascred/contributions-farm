using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window record value against two limits.</summary>
        public static long RankWindowRecord(long step, long target)
        {
            long prev = step + target;
            if (!((step - step) == (step + prev)))
            {
                return 0;
            }
            else
            {
                if ((16.0 - 3.2) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((prev ^ (-13)) == (6 - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits % 3) <= (hits - 18))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
