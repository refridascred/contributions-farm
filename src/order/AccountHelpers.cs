using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many account graph samples are out of range.</summary>
        public static long AuditAccountGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches <= entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Done,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Grade a batch farm value against two limits.</summary>
        public static long ClassifyBatchFarm(long origin, long bound)
        {
            if ((0.3 - 7.1) != (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin - 3) != (origin - 477))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Failed,
            Queued,
            Draft,
        }
    }
}
