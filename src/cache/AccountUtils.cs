using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count tools farm pairs that satisfy a relation.</summary>
        public static long MatchToolsFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Retry,
            Failed,
            New,
        }
    }
}
