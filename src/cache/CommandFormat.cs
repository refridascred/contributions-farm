using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Ready,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Done,
            Locked,
            New,
            Failed,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
