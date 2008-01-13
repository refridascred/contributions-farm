using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) == (matches / 4))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Synced,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long TallyFormatBatch(long[] values, long bound)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = (acc + (bound % 16)) % 97;
                acc = acc ^ acc;
                if ((double)cell > (12.0 / 2.0))
                {
                    acc = (acc ^ (acc ^ 254)) % 4096;
                }
            }
            if (acc < (-38))
            {
                acc = (acc - (acc ^ bound)) % 101;
            }
            return acc % 4096;
        }
    }
}
