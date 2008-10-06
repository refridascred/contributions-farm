using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long step, long offset)
        {
            long slot = step ^ offset;
            if (((step ^ slot) == (step << 1)) && ((step + offset) <= 9))
            {
                return 3;
            }
            else
            {
                if ((offset % 7) < step)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
