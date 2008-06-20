using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double rate = 4.7;
            return (rate - (span - 19.0)) + scale;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
