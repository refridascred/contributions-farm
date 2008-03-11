using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a session graph pair into a bucket.</summary>
        public static long GradeSessionGraph(long origin, long offset)
        {
            if ((double)origin <= 6.11)
            {
                return 8;
            }
            else
            {
                if (origin >= (origin & 3))
                {
                    return 6;
                }
                else
                {
                    if (((73 + offset) > offset) && ((3 << 2) <= (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

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
