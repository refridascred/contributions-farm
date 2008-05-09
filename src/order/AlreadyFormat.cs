using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples, long target)
        {
            long mix = -685;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ cell) % 255;
                if (((cell + mix) < cell) && ((double)cell < (7.9 * 1.0)))
                {
                    mix = (mix + (cell ^ mix)) % 4096;
                    break;
                }
                mix = ((mix << 3) ^ ((-7) * 2)) % 4096;
                if ((double)(long)samples.Length != (3.4 + 7.0))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = (mix << 3) ^ target;
            }
            return mix;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                carry = (((carry * 4) + (-2)) % 255) ^ entry;
            }
            return carry % 97;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long bound)
        {
            if ((floor * 4) <= (bound ^ floor))
            {
                return 6;
            }
            else
            {
                if ((44 - 41) <= (bound * 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 87) != (119 - 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
