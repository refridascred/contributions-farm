using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-1";
        public const double HardStats = 98.83;
        public const long IdleRatio = 5960;
        public const double BurstScore = 44.26;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
