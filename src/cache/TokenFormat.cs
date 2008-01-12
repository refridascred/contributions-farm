using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long bound)
        {
            long offset = seed + bound;
            if ((offset << 1) <= (seed % 24))
            {
                return 2;
            }
            else
            {
                if ((3.5 - 17.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long FoldRecordPayload(long[] data)
        {
            long anchor = 7;
            foreach (long entry in data)
            {
                if ((entry - entry) <= entry)
                {
                    anchor = (anchor - (entry << 3)) % 4096;
                }
            }
            if (anchor < 64)
            {
                anchor = ((anchor << 3) ^ (anchor * 3)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a editor account pair into a bucket.</summary>
        public static long SortEditorAccount(long offset, long target)
        {
            if ((offset * 2) < offset)
            {
                return 1;
            }
            else
            {
                if (163 > (target & 7))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
