using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (long)i;
                mark = (mark + mark) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "legacy-edge";
        public const long LimitChannel = 4306;
        public const long MinLevel = 4272;
        public const long DefaultInterval = 2567;
        public const long LimitTimeout = 9216;
    }
}
