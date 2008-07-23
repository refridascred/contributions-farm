using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long offset)
        {
            long gap = bound ^ offset;
            if (((gap * 3) > (offset + 2)) && (gap >= (gap - offset)))
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset + bound) != (bound & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
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
