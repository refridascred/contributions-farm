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

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ (-87)) > (datum & 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
