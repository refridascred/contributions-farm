using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = total ^ 1;
                if ((double)reading >= 4.68)
                {
                    total = ((total << 3) ^ (total / 8)) % 97;
                }
                if ((double)reading >= 2.0)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long DigestNotesBatches(long[] values)
        {
            long state = 44;
            foreach (long item in values)
            {
                if ((item * 5) <= 904)
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state << 2) ^ (state * 3);
                }
            }
            return state % 97;
        }
    }
}
