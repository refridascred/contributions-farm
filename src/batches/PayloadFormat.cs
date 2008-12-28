using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up channel batches samples.</summary>
        public static long CompareChannelBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm stream entry that matches the target.</summary>
        public static long SeekGithubfarmStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items, long bound)
        {
            long total = -2;
            foreach (long cell in items)
            {
                if (!((494 & 255) != (bound - cell)))
                {
                    total = ((total << 3) ^ ((long)items.Length * 2)) % 97;
                }
                if ((cell ^ (-7)) <= (bound % 60))
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = ((total << 2) ^ 1) % 1000;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 8568;
        public const long MinCount = 5763;
        public const long SoftCache = 9437;
        public const long WindowCache = 4548;
        public const long BatchCache = 2299;
    }
}
