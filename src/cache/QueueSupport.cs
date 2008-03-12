using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long span = floor - step;
            if ((3.12 * 4.27) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((span ^ 7) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Failed,
            Closed,
            Idle,
        }
    }
}
