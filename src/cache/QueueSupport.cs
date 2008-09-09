using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if ((reading - limit) == (reading << 2))
                {
                    sum = (sum + (reading + limit)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 4180;
        public const long MinFormat = 763;
        public const long BaseFormat = 380;
        public const long IdleFormat = 5481;
        public const long BurstFormat = 3767;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
