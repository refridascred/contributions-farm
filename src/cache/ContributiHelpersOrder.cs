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

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
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
