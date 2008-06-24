using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long floor)
        {
            long score = 2;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ (score + datum)) % 255;
                if ((score + floor) > (score - datum))
                {
                    score = score + (94 + floor);
                }
            }
            return score;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor <= (-79))
                {
                    anchor = anchor - (floor + 507);
                    anchor = (anchor * 4) + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
