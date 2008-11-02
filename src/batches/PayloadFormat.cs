using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 7649;
        public const long WindowFilter = 529;
        public const long MinSize = 8036;
        public const double MaxSize = 43.58;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long CombineWindowBuffer(long[] values, long bound)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = ((mix << 3) ^ reading) % 4096;
            }
            if (mix > 45)
            {
                mix = ((mix * 4) + (bound + 3)) % 1000;
            }
            return mix % 1000;
        }
    }
}
