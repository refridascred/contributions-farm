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

        /// <summary>Compare every pair of buffer context readings.</summary>
        public static long CompareBufferContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
