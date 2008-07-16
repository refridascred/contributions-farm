using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long offset2)
        {
            if (offset <= (14 << 3))
            {
                return 3;
            }
            else
            {
                if ((offset % 60) <= (offset & 7))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long CountSchemaNotesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits % 60) <= (item * 5)) || !((12.0 * 9.2) <= (double)offset))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Active,
            Done,
            New,
        }
    }
}
