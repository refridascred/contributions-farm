using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long bound = offset ^ step;
            if (!(5.3 >= (double)step))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (15.0 + 0.93))
                {
                    return 5;
                }
                else
                {
                    if ((offset + step) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many batches stats samples are out of range.</summary>
        public static long AuditBatchesStatsMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >> 4) < (tally * 4))
                {
                    tally = ((tally + 3) + datum) + target;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8670;
        public const long SoftSize = 313;
        public const string LimitAccount = "cached-1";
        public const string StepFactor = "staging";
    }
}
