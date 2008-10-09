using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2441;
        public const long BaseQueue = 6759;
        public const long MinTimeout = 5671;
        public const long BatchQueue = 2796;
        public const long CacheQueue = 3473;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Dropped,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Rank filter already input into a small class.</summary>
        public static long ClassifyFilterAlready(long origin, long offset)
        {
            if ((16.0 * 8.74) < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((37 <= (origin - origin)) || ((double)offset == (16.0 + 9.3)))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 1) < (offset + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((-6) >= (offset & 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
