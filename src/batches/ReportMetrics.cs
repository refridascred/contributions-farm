using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the farm checks series from a seed.</summary>
        public static long RollFarmChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= seed)
                {
                    score = (score ^ seed) % 101;
                    continue;
                }
                else
                {
                    score = score - (score + 45);
                }
                if (((long)i < (score << 1)) || ((double)score < 1.55))
                {
                    score = (score * 4) + seed;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Paused,
            Draft,
        }
    }
}
