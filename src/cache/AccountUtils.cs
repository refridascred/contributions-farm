using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Done,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long floor)
        {
            if ((floor > 3) || ((seed >> 4) >= floor))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (7.1 + 14.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed != (3.2 + 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 12) > (seed << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (entry + entry)) && ((matches + matches) >= (entry / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
