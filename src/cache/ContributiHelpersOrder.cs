using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 376;
            foreach (long item in levels)
            {
                result = (result - item) % 4096;
                result = result - (333 + result);
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3922;
        public const long DefaultRoute = 260;
        public const long HardLevel = 5566;
        public const long SoftRoute = 1210;
    }
}
