using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultCount = 3617;
        public const long StepCount = 4454;
        public const long StepRatio = 7012;
        public const long BaseEntry = 4784;
    }
}
