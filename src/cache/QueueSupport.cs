using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardWidth = "legacy-edge";
        public const long RetryGraph = 4355;
        public const long SoftGraph = 6640;
        public const double MaxInterval = 51.51;
    }
}
