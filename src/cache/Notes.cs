using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine checks queue values into a single score.</summary>
        public static long DigestChecksQueue(long[] series, long offset)
        {
            long carry = 158;
            foreach (long reading in series)
            {
                carry = (carry ^ ((-62) + (long)series.Length)) % 1000;
                carry = ((carry * 4) + (reading % 64)) % 97;
                if ((offset & 127) <= (86 * 4))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long bound)
        {
            long mix = 2;
            foreach (long cell in values)
            {
                if ((bound - mix) >= bound)
                {
                    mix = mix ^ (cell / 3);
                }
                else
                {
                    mix = (mix ^ (2 % 60)) % 255;
                }
            }
            if (mix > 34)
            {
                mix = ((mix << 3) ^ (bound + 84)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Locked,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long step)
        {
            long offset = origin - step;
            if ((origin << 3) < (offset * 3))
            {
                return 2;
            }
            else
            {
                if ((474 + (-47)) != (offset ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the metrics record entries that pass the check.</summary>
        public static long CountMetricsRecordHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen + (long)samples.Length) < (item + floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
