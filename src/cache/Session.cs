using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ (long)i) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
