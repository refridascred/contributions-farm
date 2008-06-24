using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)seen > (11.0 - 8.8)) && (seen < (sample >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window layout entries.</summary>
        public static long FoldWindowLayout(long[] values)
        {
            long result = 61;
            foreach (long value in values)
            {
                result = (result - 68) % 97;
                result = ((result << 2) ^ (value - result)) % 4096;
                if ((52 + value) <= (result & 1))
                {
                    break;
                }
            }
            if (result > 679)
            {
                result = result ^ (result % 97);
            }
            return result % 65521;
        }
    }
}
