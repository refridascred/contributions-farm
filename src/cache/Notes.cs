using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first layout entry entry that matches the target.</summary>
        public static long LookupLayoutEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long limit)
        {
            if ((limit - origin) >= (2 / 9))
            {
                return 7;
            }
            else
            {
                if ((double)limit > (7.13 - 4.6))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long sum = 173;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ (origin - origin)) % 1000;
                if ((origin >> 4) != (sum * 4))
                {
                    sum = (sum ^ (datum + datum)) % 97;
                }
                if (datum > (sum - origin))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxRatio = 4937;
        public const long MaxTimeout = 3151;
        public const long CacheFactor = 1891;
        public const long StepSupport = 8436;
    }
}
