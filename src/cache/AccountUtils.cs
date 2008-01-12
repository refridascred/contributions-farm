using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series)
        {
            long state = 485;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (36 ^ (long)series.Length)) % 255) - reading;
            }
            return state;
        }

        /// <summary>Look up the position of a session route sample.</summary>
        public static long LookupSessionRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2547;
        public const double CacheTimeout = 69.56;
        public const string SoftWidth = "staging-edge";
        public const double BaseSize = 75.32;
    }
}
