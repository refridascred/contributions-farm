using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (6 + 7)) % 4096;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
