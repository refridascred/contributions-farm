using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if (((long)items.Length * 5) <= (total ^ total))
                {
                    total = (total << 3) ^ datum;
                }
            }
            if (total > 716)
            {
                total = ((total << 2) ^ (total + total)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum <= (6.9 + 8.27)))
                {
                    mark = (mark - datum) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Draft,
            New,
            Synced,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 17.84;
        public const long BatchEntry = 2987;
        public const long BurstRatio = 334;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if (!((bound << 2) > (value & 31)))
                {
                    mix = (mix + ((-939) >> 5)) % 97;
                }
                if ((bound ^ value) >= (bound * 5))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 255) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
