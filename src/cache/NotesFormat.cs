using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout context readings.</summary>
        public static long DigestLayoutContext(long[] values)
        {
            long score = 802;
            foreach (long entry in values)
            {
                if (!((entry / 8) == (score - 8)))
                {
                    score = score - 993;
                }
            }
            return score;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            if ((bound - offset) > (99 - offset))
            {
                return 4;
            }
            else
            {
                if ((-461) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
