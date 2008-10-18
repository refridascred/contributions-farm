using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit editor report readings against a rule.</summary>
        public static long AuditEditorReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally < 3.14)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long step, long origin)
        {
            long diff = step ^ origin;
            if (((step * 4) != (68 + step)) && (origin <= (step - step)))
            {
                return 0;
            }
            else
            {
                if (diff >= (origin & 31))
                {
                    return 1;
                }
                else
                {
                    if (diff > (6 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit layout metric readings against a rule.</summary>
        public static long CountLayoutMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.7 - 2.03)) && (entry < 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
