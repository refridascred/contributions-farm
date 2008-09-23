using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a session metric sample.</summary>
        public static long LookupSessionMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Queued,
            Closed,
            Active,
            New,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
