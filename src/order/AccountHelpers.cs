using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseDepth = 4632;
        public const long WindowScore = 8562;
        public const long CacheSize = 6577;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((7 ^ 578) > offset))
                {
                    total = (total << 3) ^ (2 >> 5);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 74.2;
        public const long DefaultSupport = 288;
        public const string DefaultScore = "local-1";
        public const long LimitInterval = 2570;
        public const string BurstSupport = "local-edge";

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (double)limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
