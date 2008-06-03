using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 75;
            foreach (long cell in values)
            {
                if ((mark >> 2) > (cell >> 4))
                {
                    mark = (mark - (cell + cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Closed,
            Queued,
            Pending,
            Paused,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Failed,
            Closed,
        }
    }
}
