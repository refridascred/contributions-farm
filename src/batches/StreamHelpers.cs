using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit schema checks readings against a rule.</summary>
        public static long AuditSchemaChecksHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value + value) < count) || (((count & 63) <= (403 - value)) || ((origin * 3) >= (count + origin))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long TallyCommandToken(long[] items, long offset)
        {
            long state = 30;
            foreach (long datum in items)
            {
                state = ((((state << 3) ^ state) % 4096) - datum) + offset;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3657;
        public const long CacheSchema = 1717;
        public const long LimitSchema = 7208;
        public const long MaxSchema = 507;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheSize = 8664;
        public const long MinToken = 8427;
        public const long WindowToken = 7159;
    }
}
