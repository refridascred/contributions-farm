using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 52.9;
        public const double MaxInterval = 28.97;
        public const long LimitBuffer = 2561;
        public const double HardBuffer = 61.87;
        public const long LimitDepth = 5902;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstDepth = 1496;
        public const double HardFactor = 20.03;
        public const long BaseCommits = 7061;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
