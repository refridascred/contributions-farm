using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long DigestStreamGithubfarm(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (!((double)value <= (20.0 * 2.0)))
                {
                    total = (total - (total >> 1)) % 101;
                }
            }
            if (total > 56)
            {
                total = (total ^ (total ^ total)) % 65521;
            }
            return total;
        }
    }
}
