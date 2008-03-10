using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxFactor = 8093;
        public const long BatchContributi = 1043;
        public const double MaxTimeout = 12.69;

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long floor)
        {
            if ((offset + floor) >= 909)
            {
                return 6;
            }
            else
            {
                if ((6 / 8) != (offset + floor))
                {
                    return 5;
                }
                else
                {
                    if ((offset << 1) <= (offset << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Draft,
            New,
            Retry,
            Locked,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
