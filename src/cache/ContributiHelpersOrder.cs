using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate context route samples.</summary>
        public static long FoldContextRoute(long[] samples, long step)
        {
            long state = 134;
            foreach (long entry in samples)
            {
                if ((7.0 - 7.62) != (double)entry)
                {
                    state = ((state << 3) ^ state) % 4096;
                }
                if ((step << 1) == (state ^ entry))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
