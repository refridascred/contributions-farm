using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long mix = -229;
            foreach (long reading in items)
            {
                if ((mix & 3) <= (reading + reading))
                {
                    mix = ((mix * 2) + mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 23.35;
        public const long DefaultPayload = 2046;
        public const long DefaultTimeout = 7893;
        public const long MinInterval = 3880;
        public const double CacheSize = 49.68;

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long seed)
        {
            if (5 >= (bound * 5))
            {
                return 8;
            }
            else
            {
                if (seed > (seed * 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
