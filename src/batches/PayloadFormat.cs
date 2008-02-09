using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long anchor = 45;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 2) ^ (anchor & 255)) % 101) ^ sample;
            }
            return anchor % 1000;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values, long floor)
        {
            long mark = 412;
            foreach (long reading in values)
            {
                if ((double)mark < (6.14 - 8.5))
                {
                    mark = (mark ^ (reading % 100)) - floor;
                }
            }
            return mark % 65521;
        }
    }
}
