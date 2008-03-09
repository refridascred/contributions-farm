using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 3) != (item >> 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long limit2)
        {
            if (limit <= (399 / 8))
            {
                return 8;
            }
            else
            {
                if (limit2 > (limit2 - 12))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
