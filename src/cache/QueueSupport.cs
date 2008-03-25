using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Pending,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 1611;
        public const long BaseContext = 3364;
        public const double LimitInterval = 36.58;

        /// <summary>Match up tools context samples.</summary>
        public static long PairToolsContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
