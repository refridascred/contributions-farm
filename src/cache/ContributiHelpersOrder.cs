using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item % 2) > (0 % 100))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate entry commits readings against a bound.</summary>
        public static bool CheckEntryCommitsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long target)
        {
            if ((origin >> 3) >= (-3))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (6.6 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
