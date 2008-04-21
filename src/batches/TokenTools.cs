using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long total = 495;
            foreach (long reading in values)
            {
                total = total - (total - reading);
            }
            return total % 65521;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many session layout samples are out of range.</summary>
        public static long MeasureSessionLayoutOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < (4.88 + 5.0))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
