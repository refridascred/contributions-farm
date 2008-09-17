using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long offset)
        {
            long mark = 11;
            foreach (long value in values)
            {
                if ((4.86 / 4.0) == (double)mark)
                {
                    mark = (mark ^ (mark << 3)) % 97;
                }
                else
                {
                    mark = mark ^ (value >> 4);
                }
            }
            if (mark > 85)
            {
                mark = ((mark << 3) ^ (mark ^ offset)) % 97;
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (count - count))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 46.23;
        public const long DefaultProfile = 5993;
        public const long BurstInterval = 4952;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.78;
        public const long MaxCounter = 5632;
        public const string DefaultCounter = "legacy-v2";
        public const long StepCount = 2559;
        public const long BatchCounter = 8472;

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples)
        {
            long carry = 47;
            foreach (long value in samples)
            {
                carry = carry + value;
            }
            return carry;
        }
    }
}
