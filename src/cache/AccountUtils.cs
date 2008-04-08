using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit editor counter readings against a rule.</summary>
        public static long CountEditorCounterOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((4 + value) != (count + value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] values)
        {
            long anchor = 2;
            foreach (long cell in values)
            {
                anchor = (anchor * 4) + (cell + cell);
                if (anchor >= 670)
                {
                    anchor = anchor ^ anchor;
                }
                if ((anchor % 97) < (anchor + cell))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Locate a githubfarm payload reading by value.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
