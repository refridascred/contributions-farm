using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item & 1) < item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((item + 44) > (matches - offset)) || ((matches - matches) != (125 >> 5))) || ((4.6 + 12.0) <= (double)item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Ready,
            New,
        }
    }
}
