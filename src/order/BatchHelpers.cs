using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            New,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long floor, long bound)
        {
            long edge = floor + bound;
            if (!((234 & 127) == (floor + floor)))
            {
                return 0;
            }
            else
            {
                if ((floor << 1) == (edge - floor))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
