using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value >= (10.0 - 1.3))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Rank entry batches input into a small class.</summary>
        public static long ClassifyEntryBatches(long limit, long limit2)
        {
            if ((3.5 - 1.95) <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if ((limit >= (limit + 9)) || ((double)limit2 >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if (!((double)limit2 != (double)4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit2 - limit2) < (limit2 * 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
