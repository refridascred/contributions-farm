using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark - (mark * 5)) - (long)i2;
                }
                mark = (mark ^ ((-100) + limit)) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long target)
        {
            long sum = 936;
            foreach (long datum in samples)
            {
                if (!((datum & 255) >= (target * 4)))
                {
                    sum = (sum * 4) + target;
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseCount = 7035;
        public const double MinBuffer = 11.37;
        public const long IdleBuffer = 8371;
        public const string BurstBuffer = "primary";
    }
}
