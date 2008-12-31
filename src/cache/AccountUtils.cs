using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine already command values into a single score.</summary>
        public static long TallyAlreadyCommand(long[] samples, long floor)
        {
            long anchor = 25;
            foreach (long cell in samples)
            {
                if (4 >= anchor)
                {
                    anchor = ((((anchor * 5) + 79) % 97) ^ cell) - floor;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value - matches) == (74 ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
