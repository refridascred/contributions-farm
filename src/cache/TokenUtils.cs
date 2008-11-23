using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long TotalOrderFarm(long[] data, long bound)
        {
            long result = 436;
            foreach (long value in data)
            {
                if ((4 ^ bound) > (result - value))
                {
                    result = (result + value) % 97;
                }
            }
            return result;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
