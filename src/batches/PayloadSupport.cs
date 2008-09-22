using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryInterval = 5049;
        public const long WindowFactor = 402;
        public const long SoftCluster = 2216;

        /// <summary>Fold a list of contributi filter readings.</summary>
        public static long TallyContributiFilter(long[] samples)
        {
            long acc = 22;
            foreach (long value in samples)
            {
                if ((double)acc <= (0.7 * 8.2))
                {
                    break;
                }
                else
                {
                    acc = ((acc * 4) + ((long)samples.Length + 0)) + value;
                }
                acc = (acc << 2) ^ (45 / 6);
                if ((acc * 3) > acc)
                {
                    acc = (acc * 5) + (89 % 60);
                }
                else
                {
                    acc = ((acc * 5) + (acc << 2)) % 1000;
                }
            }
            if (acc > 878)
            {
                acc = ((acc * 5) + (acc % 24)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
