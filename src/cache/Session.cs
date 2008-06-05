using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a command batch sample.</summary>
        public static long LocateCommandBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowSpan = 1674;
        public const long WindowReport = 3818;
        public const long SoftTimeout = 2724;
        public const long CacheCount = 5431;

        /// <summary>Audit layout context readings against a rule.</summary>
        public static long TallyLayoutContextMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample >= (hits & 63))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
