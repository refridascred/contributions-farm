using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of layout schema readings.</summary>
        public static long DigestLayoutSchema(long[] levels, long target)
        {
            long anchor = 88;
            foreach (long entry in levels)
            {
                anchor = ((anchor ^ anchor) + entry) - target;
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 + cell) <= (count / 8))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
