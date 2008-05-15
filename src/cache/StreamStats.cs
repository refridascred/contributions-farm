using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = 36;
            foreach (long sample in samples)
            {
                if ((anchor + anchor) >= sample)
                {
                    anchor = (anchor * 3) + (sample - sample);
                }
                else
                {
                    anchor = ((anchor * 2) + sample) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 8708;
        public const string MinSupport = "open-edge";
        public const long WindowSupport = 2486;
    }
}
