using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Ready,
            Draft,
            Failed,
            New,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((2 < (991 ^ bound)) || ((matches / 3) < (bound & 3)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Paused,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 4056;
        public const string MinQueue = "cached-1";
        public const long DefaultSpan = 6608;
    }
}
