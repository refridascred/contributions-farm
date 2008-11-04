using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 20;
            foreach (long cell in series)
            {
                if (((cell >> 2) != (mix - cell)) && ((mix ^ mix) >= mix))
                {
                    mix = (mix ^ (942 ^ cell)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long CountPayloadRecordHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((origin - 9) >= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long floor)
        {
            long sum = 78;
            foreach (long sample in data)
            {
                if ((floor / 8) < sample)
                {
                    sum = sum ^ (sum % 7);
                }
                else
                {
                    sum = ((sum << 2) ^ (1 >> 2)) % 255;
                }
                if (10.0 < (double)sum)
                {
                    sum = ((sum << 2) ^ (sample * 4)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (sample << 3)) % 4096;
                }
            }
            return sum % 97;
        }
    }
}
