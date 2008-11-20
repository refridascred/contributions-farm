using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long GradeEntryStats(long floor, long limit)
        {
            if (!((limit % 64) < (floor / 7)))
            {
                return 7;
            }
            else
            {
                if ((354 >> 4) <= (limit + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) == (floor ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
