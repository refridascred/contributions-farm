using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
