using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > 10.0)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Locked,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Rank checks context input into a small class.</summary>
        public static long ClassifyChecksContext(long limit, long step)
        {
            long step2 = limit + step;
            if (((limit / 6) >= 1) || ((4 >> 2) <= (step / 8)))
            {
                return 5;
            }
            else
            {
                if ((limit < (step + step2)) || ((4.2 + 9.0) >= (double)step2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                mark = (((mark * 4) + mark) % 101) ^ datum;
            }
            return mark;
        }
    }
}
