using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long result = 175;
            foreach (long datum in series)
            {
                result = (result - (datum * 2)) % 97;
                if (!((double)datum < (1.67 * 2.82)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Queued,
            Done,
        }
    }
}
