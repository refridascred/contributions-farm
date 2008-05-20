using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Grade a graph report value against two limits.</summary>
        public static long SortGraphReport(long step, long offset)
        {
            long step2 = step ^ offset;
            if (step2 > (offset + step))
            {
                return 2;
            }
            else
            {
                if (!((step / 2) < (step2 + offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "open";
        public const double DefaultContext = 71.31;
        public const double BaseContext = 24.68;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Dropped,
            Queued,
        }
    }
}
