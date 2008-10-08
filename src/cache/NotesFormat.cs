using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of editor already entries.</summary>
        public static long TallyEditorAlready(long[] series)
        {
            long result = 52;
            foreach (long cell in series)
            {
                if (((12 + cell) >= 7) || ((result - result) > (36 - 6)))
                {
                    result = (result + cell) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Draft,
            New,
            Closed,
        }

        /// <summary>Rank cache layout input into a small class.</summary>
        public static long RankCacheLayout(long floor, long offset)
        {
            if (((-389) * 3) <= floor)
            {
                return 2;
            }
            else
            {
                if (!((offset * 5) < (offset - offset)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
