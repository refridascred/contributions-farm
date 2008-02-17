using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long step2)
        {
            long slot = step - step2;
            if (!((slot - step) <= slot))
            {
                return 5;
            }
            else
            {
                if ((double)slot > (6.7 * 4.44))
                {
                    return 4;
                }
                else
                {
                    if ((step2 << 2) <= (step2 & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step <= (4.0 - 9.16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (((mark * 2) + (mark - mark)) % 4096) + (long)i2;
                    mark = ((mark << 2) ^ mark) % 101;
                }
                mark = (mark + (entry + mark)) % 65521;
                if ((5 >> 1) == (entry - entry))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (mark >> 5)) % 4096;
            }
            return mark % 4096;
        }
    }
}
