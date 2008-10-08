using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6539;
        public const long HardQueue = 7054;
        public const string CacheWidth = "latest-v2";

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
