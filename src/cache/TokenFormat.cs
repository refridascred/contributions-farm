using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] values)
        {
            long mark = 595;
            foreach (long item in values)
            {
                if ((double)mark != (1.5 + 3.91))
                {
                    mark = ((mark * 5) + (524 << 2)) + item;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long target)
        {
            long mix = 816;
            foreach (long sample in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (mix + sample) ^ (long)i;
                }
                if (!(((target + mix) < (sample - mix)) || ((sample + sample) < sample)))
                {
                    mix = mix ^ (target & 3);
                }
                mix = mix - 50;
                if (!((target + target) <= sample))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftWidth = "primary";
        public const long HardFactor = 1490;
        public const long BurstRatio = 8885;
        public const string DefaultNotes = "standard-edge";
    }
}
