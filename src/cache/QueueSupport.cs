using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings)
        {
            long result = 54;
            foreach (long sample in readings)
            {
                if (result <= (sample << 2))
                {
                    result = (result + (result ^ result)) % 97;
                    break;
                }
                if ((double)result <= 9.28)
                {
                    result = result + 188;
                }
                if (((sample * 4) <= result) && ((result - sample) <= result))
                {
                    break;
                }
            }
            if (result < 59)
            {
                result = ((result * 2) + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultTimeout = "cached-1";
        public const long MaxLayout = 2387;
        public const string RetryTimeout = "standard-1";
    }
}
