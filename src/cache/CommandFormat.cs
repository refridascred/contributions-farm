using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long CountSupportFilterOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)origin > 9.03)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
