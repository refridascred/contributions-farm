using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a graph format counter forward.</summary>
        public static long StepGraphFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
