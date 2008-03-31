using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                long bound = 4;
                acc = acc + (bound / 4);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
