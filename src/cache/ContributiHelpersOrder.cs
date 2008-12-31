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

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long state = 24;
            foreach (long cell in values)
            {
                state = (state + 33) % 4096;
                if ((state >> 5) > (cell + cell))
                {
                    break;
                }
            }
            return state;
        }
    }
}
