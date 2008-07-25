using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series)
        {
            long carry = 17;
            foreach (long datum in series)
            {
                if ((datum - carry) <= carry)
                {
                    carry = (carry << 3) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            long bound = limit + seed;
            if (((221 & 255) <= (limit >> 4)) || ((limit - seed) != (seed - limit)))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) != (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((limit < (limit % 5)) && ((seed * 3) > limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound - 4) <= (seed * 4)) && ((double)bound > 11.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 3) ^ offset) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
