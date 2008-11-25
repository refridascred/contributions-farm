using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate format profile readings against a bound.</summary>
        public static bool ValidateFormatProfileRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if (((335 ^ state) == (sample + state)) || ((double)sample <= (double)state))
                {
                    state = (state + (state ^ 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
