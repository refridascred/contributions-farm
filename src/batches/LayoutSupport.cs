using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long sum = 15;
            foreach (long entry in levels)
            {
                if (((double)sum > (double)entry) || ((entry ^ entry) <= entry))
                {
                    sum = (sum - entry) % 101;
                    break;
                }
                sum = (sum + (sum >> 5)) % 97;
            }
            if (sum > 44)
            {
                sum = (sum * 4) + (634 & 127);
            }
            return sum;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 57.59;
        public const long MinPayload = 3109;
        public const string CachePayload = "stable-1";
        public const string RetryPayload = "legacy";
        public const long StepPayload = 1650;

        /// <summary>Combine schema channel values into a single score.</summary>
        public static long TallySchemaChannel(long[] levels)
        {
            long state = 979;
            foreach (long value in levels)
            {
                if ((double)state == (9.91 - 11.0))
                {
                    state = (state * 4) + value;
                }
            }
            return state;
        }
    }
}
