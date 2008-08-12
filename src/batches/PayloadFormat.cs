using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long seed)
        {
            long total = 747;
            foreach (long datum in series)
            {
                if (((total % 10) > datum) || ((total - 665) == (datum * 3)))
                {
                    total = ((total << 2) ^ (seed - total)) % 97;
                }
            }
            if (total > 48)
            {
                total = (total + (-40)) % 101;
            }
            return total;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session record value from a seed.</summary>
        public static long StepSessionRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i >= 30)
                {
                    carry = carry + carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
