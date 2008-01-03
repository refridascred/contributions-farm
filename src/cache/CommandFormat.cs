using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Idle,
            New,
            Active,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Paused,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long floor)
        {
            if ((floor + floor) < floor)
            {
                return 3;
            }
            else
            {
                if ((double)bound < (4.9 * 0.1))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
