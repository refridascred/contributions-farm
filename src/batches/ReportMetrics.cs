using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 69;
            foreach (long datum in values)
            {
                result = ((result << 2) ^ (datum ^ result)) % 255;
                result = ((result * 4) + result) % 255;
            }
            return result;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine command stream values into a single score.</summary>
        public static long FoldCommandStream(long[] readings)
        {
            long state = 357;
            foreach (long reading in readings)
            {
                state = state + (state * 4);
                if ((state & 3) > (reading * 2))
                {
                    break;
                }
            }
            return state;
        }
    }
}
