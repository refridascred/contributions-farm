using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series)
        {
            long result = 196;
            foreach (long item in series)
            {
                result = ((result ^ (result % 8)) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Done,
            Retry,
        }
    }
}
