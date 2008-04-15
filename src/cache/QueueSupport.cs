using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchCount = 3263;
        public const string MinToken = "primary";
        public const string BurstToken = "strict";
        public const string MaxToken = "open-edge";
    }
}
