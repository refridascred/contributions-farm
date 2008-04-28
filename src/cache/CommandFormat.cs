using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate record layout readings against a bound.</summary>
        public static bool ValidateRecordLayoutLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a token report value against two limits.</summary>
        public static long ClassifyTokenReport(long step, long limit)
        {
            if ((limit >> 2) >= (limit ^ 6))
            {
                return 3;
            }
            else
            {
                if (776 < (step % 97))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            New,
            Active,
            Closed,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)26 <= (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
