using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Idle,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Match up stats filter samples.</summary>
        public static long MatchStatsFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches >= (495 & 1))
                {
                    matches = ((matches + 2) ^ datum) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
