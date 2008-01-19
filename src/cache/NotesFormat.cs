using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next already schema value from a seed.</summary>
        public static long SeriesAlreadySchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((sum + sum) < (seed >> 5))
                {
                    sum = (sum ^ (seed >> 4)) % 97;
                    sum = (sum << 3) ^ sum;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 3) ^ (sum << 3)) ^ (long)i2;
                }
                sum = sum + (seed + seed);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long anchor = 19;
            foreach (long datum in levels)
            {
                if ((18.0 / 9.0) < (double)datum)
                {
                    anchor = ((anchor * 5) + 5) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (anchor / 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Active,
            New,
            Failed,
            Retry,
        }
    }
}
