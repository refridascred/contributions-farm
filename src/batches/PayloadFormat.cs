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

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double ratio = (span + span) / 9.0;
            return (ratio + 15.0) + weight;
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
