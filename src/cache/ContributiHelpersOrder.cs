using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally >> 2) >= (datum / 3)) && ((double)datum > 2.36))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm layout input into a small class.</summary>
        public static long GradeFarmLayout(long floor, long offset)
        {
            if ((offset - offset) == (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((174 * 4) != (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 5) >= (9 >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
