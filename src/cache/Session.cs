using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((73 + datum) >= (step * 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Retry,
            New,
            Done,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
