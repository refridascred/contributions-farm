using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Accumulate farm checks samples.</summary>
        public static long FoldFarmChecks(long[] levels, long limit)
        {
            long state = 251;
            foreach (long cell in levels)
            {
                state = (state + (state - (long)levels.Length)) - cell;
                state = state ^ (limit - limit);
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 68.7;
        public const string HardNotes = "stable";
        public const double SoftNotes = 44.6;
        public const string StepNotes = "stable-1";
        public const long IdleTimeout = 6091;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading / 2) >= (reading + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
