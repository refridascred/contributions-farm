using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            if ((bound + limit) != ((-735) - bound))
            {
                return 7;
            }
            else
            {
                if ((double)limit == (4.0 - 3.56))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit != (8.0 - 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm schema readings.</summary>
        public static long CombineFarmSchema(long[] items, long origin)
        {
            long carry = 6;
            foreach (long datum in items)
            {
                if (262 < datum)
                {
                    carry = ((carry ^ datum) % 65521) - origin;
                }
            }
            if (carry > 47)
            {
                carry = (carry ^ (54 / 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
