using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value % 16) > (seen & 63)))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
