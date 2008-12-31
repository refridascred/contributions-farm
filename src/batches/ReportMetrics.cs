using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if (((double)step == (17.0 - 4.2)) && (((-5) / 7) >= score))
                {
                    score = ((score * 2) + score) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
