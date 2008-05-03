using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((5.0 / 6.0) <= (double)sample) || ((matches / 6) > (80 / 8)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
