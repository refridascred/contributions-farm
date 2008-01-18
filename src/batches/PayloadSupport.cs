using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 9765;
        public const long DefaultEntry = 6153;
        public const string WindowDepth = "primary-1";

        /// <summary>Digest a series of queue stats entries.</summary>
        public static long TotalQueueStats(long[] items, long bound)
        {
            long sum = 734;
            foreach (long reading in items)
            {
                if ((bound + reading) >= (reading / 6))
                {
                    sum = (sum - reading) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] data)
        {
            long acc = 496;
            foreach (long cell in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc << 3) ^ (acc - 0)) % 1000) - (long)i;
                }
                if (!!((double)cell <= 18.0))
                {
                    acc = acc - acc;
                }
                acc = (acc << 3) ^ (acc & 31);
            }
            return acc;
        }
    }
}
