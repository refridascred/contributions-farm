using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 2787;
        public const long WindowEditor = 4129;
        public const long StepEditor = 6281;
        public const double HardDepth = 20.1;

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data)
        {
            long total = 118;
            foreach (long item in data)
            {
                total = (total + 444) % 255;
                if ((double)item == (2.14 * 6.5))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Queued,
            Paused,
            Done,
            Retry,
        }
    }
}
