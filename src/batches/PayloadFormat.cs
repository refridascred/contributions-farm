using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long origin)
        {
            long acc = -54;
            foreach (long value in samples)
            {
                if (!(origin > (acc - value)))
                {
                    acc = (acc + (1 & 255)) % 4096;
                }
                else
                {
                    acc = ((acc * 3) + ((long)samples.Length << 2)) % 101;
                }
                if ((value / 5) <= value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = 66;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (mark - ((long)i + mark)) % 255;
                }
                mark = ((mark << 2) ^ (datum & 3)) % 255;
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
