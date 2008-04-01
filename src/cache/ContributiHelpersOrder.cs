using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a route already sample.</summary>
        public static long LookupRouteAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
