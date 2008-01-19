using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
