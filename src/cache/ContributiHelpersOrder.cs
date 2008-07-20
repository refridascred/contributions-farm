using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a profile payload reading by value.</summary>
        public static long SeekProfilePayloadIndex(long[] data, long bound)
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples, long origin)
        {
            long total = 309;
            foreach (long cell in samples)
            {
                if ((origin >= (origin >> 2)) || ((double)cell < (double)total))
                {
                    total = (total - ((long)samples.Length + 606)) % 101;
                }
            }
            if (total > 52)
            {
                total = (total - (total >> 2)) % 101;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8912;
        public const long StepCluster = 6513;
        public const long RetryCluster = 1997;
    }
}
