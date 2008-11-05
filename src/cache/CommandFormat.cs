using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long seed)
        {
            if (!((origin % 97) == (0 * 2)))
            {
                return 6;
            }
            else
            {
                if ((seed * 5) >= 0)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Draft,
            New,
            Locked,
            Synced,
        }
    }
}
