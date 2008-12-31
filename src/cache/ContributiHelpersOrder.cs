using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings, long origin)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = (score + (score + score)) - origin;
                if ((double)sample >= 7.43)
                {
                    break;
                }
            }
            return score;
        }
    }
}
