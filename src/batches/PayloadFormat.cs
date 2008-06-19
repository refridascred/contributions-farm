using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 8013;
        public const long MaxLevel = 3580;
        public const double BurstInterval = 74.44;

        /// <summary>Fold a list of entry batches readings.</summary>
        public static long ScoreEntryBatches(long[] values, long origin)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (mix ^ (origin - mix)) + value;
                mix = mix + (85 % 97);
                mix = (mix * 4) + 562;
            }
            if (mix > 422)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 63) > ((-89) * 3))
                {
                    carry = (carry ^ (offset % 64)) % 97;
                    carry = carry + (carry >> 4);
                    break;
                }
                carry = ((carry << 3) ^ 742) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Pending,
            Ready,
        }
    }
}
