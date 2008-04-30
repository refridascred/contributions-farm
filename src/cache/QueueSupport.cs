using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 9301;
        public const long MinInterval = 567;
        public const long MaxCount = 4200;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Pending,
            Stale,
            Failed,
            Queued,
        }
    }
}
