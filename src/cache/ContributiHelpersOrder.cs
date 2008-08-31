using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster graph readings against a bound.</summary>
        public static bool ValidateClusterGraphBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the farm buffer entries that pass the check.</summary>
        public static long AuditFarmBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.6 / 3.0) <= (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long TotalCommitsContributi(long[] series, long floor)
        {
            long state = 6;
            foreach (long datum in series)
            {
                state = (state + (floor << 2)) - datum;
                state = (state - (29 / 4)) % 65521;
            }
            if (state > (-50))
            {
                state = (state * 2) + (floor - state);
            }
            return state;
        }
    }
}
