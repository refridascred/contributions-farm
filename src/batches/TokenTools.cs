using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many contributi report samples are out of range.</summary>
        public static long CountContributiReportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((sample * 4) < (tally - sample)) || ((double)sample <= (8.53 / 6.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            long prev = target - floor;
            if ((double)target != (1.0 / 8.0))
            {
                return 7;
            }
            else
            {
                if (((prev + prev) < (floor * 2)) || ((floor + prev) < 5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
