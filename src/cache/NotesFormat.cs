using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if (((item + item) == (sum + 2)) || (sum < (long)values.Length))
                {
                    sum = (sum ^ item) % 97;
                }
                if (((item + 606) < (sum >> 5)) || (item > (item ^ sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
