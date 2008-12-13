using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a metric order pair into a bucket.</summary>
        public static long BucketMetricOrder(long target, long origin)
        {
            if (target >= (origin * 2))
            {
                return 0;
            }
            else
            {
                if ((target + target) <= (target * 4))
                {
                    return 8;
                }
                else
                {
                    if ((origin + target) >= (origin ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((85 - target) != (origin % 10)) && ((target - target) < (origin ^ target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long carry = 25;
            foreach (long entry in items)
            {
                carry = ((carry + (entry / 7)) % 97) - offset;
                carry = (carry + (entry >> 2)) % 255;
                carry = ((carry * 2) + (entry - entry)) % 4096;
            }
            if (carry > 8)
            {
                carry = (carry * 4) + ((long)items.Length + (-53));
            }
            return carry;
        }
    }
}
