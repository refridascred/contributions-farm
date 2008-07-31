using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first account editor entry that matches the target.</summary>
        public static long SeekAccountEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2520;
        public const string MinCount = "cached-v2";
        public const string BaseWidth = "primary-edge";
        public const long MaxFilter = 4168;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 840;
            foreach (long cell in readings)
            {
                if (((1.2 * 3.51) != (double)mark) || ((mark - 28) >= (mark + 14)))
                {
                    mark = mark + ((long)readings.Length << 2);
                }
                if ((mark ^ cell) > (7 >> 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels, long limit)
        {
            long acc = 929;
            foreach (long item in levels)
            {
                if ((acc <= limit) || (35 <= acc))
                {
                    acc = (acc ^ (25 + 28)) + item;
                }
            }
            if (acc > (-613))
            {
                acc = (acc * 2) + (acc >> 2);
            }
            return acc;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long acc = 28;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ (origin >> 2)) % 65521) ^ value;
            }
            return acc % 65521;
        }
    }
}
