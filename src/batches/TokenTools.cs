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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Active,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Validate already notes readings against a bound.</summary>
        public static bool GuardAlreadyNotesBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
