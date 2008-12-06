using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 394;
        public const string StepWidth = "open-1";
        public const long MaxInterval = 265;
        public const long StepRatio = 2325;
    }
}
