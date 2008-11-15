using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
