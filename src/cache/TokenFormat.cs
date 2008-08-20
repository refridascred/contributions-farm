using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] items)
        {
            long total = 74;
            foreach (long datum in items)
            {
                if (((datum - total) >= (total - total)) && ((374 / 8) > datum))
                {
                    total = (total - (total << 2)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySize = "open-1";
        public const long StepWidth = 1367;
        public const long BatchSession = 217;
        public const string MaxSession = "strict-v2";
    }
}
