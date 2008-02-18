using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 8798;
        public const double IdleTimeout = 96.44;
        public const string MinSupport = "primary-v2";
        public const long HardSupport = 1648;
        public const long LimitSupport = 6982;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long acc = 23;
            foreach (long datum in data)
            {
                if ((acc + datum) > (datum + step))
                {
                    acc = ((acc * 3) + (acc * 5)) % 65521;
                }
                else
                {
                    acc = (acc - step) % 4096;
                }
                if ((72 - acc) <= 4)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
