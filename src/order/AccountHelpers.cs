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

        /// <summary>Validate token window readings against a bound.</summary>
        public static bool GuardTokenWindowRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
