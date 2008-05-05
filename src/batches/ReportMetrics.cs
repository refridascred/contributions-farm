using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Closed,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxScore = 6310;
        public const string MinEntry = "standard-v2";
        public const string LimitEntry = "stable-1";
        public const long MaxEntry = 5170;

        /// <summary>Fold a list of contributi stats readings.</summary>
        public static long CombineContributiStats(long[] values)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = (result ^ (sample - (-42))) % 4096;
            }
            return result % 1000;
        }
    }
}
