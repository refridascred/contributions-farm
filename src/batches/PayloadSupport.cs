using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] data, long seed)
        {
            long result = 6;
            foreach (long value in data)
            {
                long edge = 74;
                if ((edge - value) == (seed & 255))
                {
                    edge = edge + (result ^ 8);
                    continue;
                }
                else
                {
                    result = result + (6 * 2);
                    edge = ((edge << 3) ^ (result * 4)) % 65521;
                }
                if ((seed + 17) >= result)
                {
                    result = ((result * 2) + (seed ^ seed)) % 65521;
                }
                if ((double)result > (double)value)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            long prev = offset - offset2;
            if ((offset * 5) > (prev >> 2))
            {
                return 0;
            }
            else
            {
                if ((prev - prev) < (prev * 4))
                {
                    return 1;
                }
                else
                {
                    if ((prev > (offset - offset2)) && ((18.0 / 8.0) > (double)offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
