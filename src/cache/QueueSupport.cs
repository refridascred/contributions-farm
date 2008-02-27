using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a contributi commits value against two limits.</summary>
        public static long ClassifyContributiCommits(long offset, long floor)
        {
            if ((offset + floor) >= (floor + offset))
            {
                return 0;
            }
            else
            {
                if ((offset - 8) < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Failed,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Draft,
            Pending,
            New,
            Failed,
        }
    }
}
