using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Dropped,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long acc = 891;
            foreach (long datum in values)
            {
                if ((acc >> 5) < acc)
                {
                    acc = ((acc - limit) % 65521) ^ datum;
                }
                else
                {
                    acc = (acc << 3) ^ (565 >> 2);
                }
            }
            if (acc < 9)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long step)
        {
            long sum = 4;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + (cell >> 1)) % 4096;
                if (((step << 1) < (70 ^ cell)) || ((double)sum >= (double)step))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
