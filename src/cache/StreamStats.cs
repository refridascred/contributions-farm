using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long limit)
        {
            long edge = offset + limit;
            if (((edge + edge) != (limit - edge)) || (edge >= (offset * 2)))
            {
                return 8;
            }
            else
            {
                if ((-9) >= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 2) + (target + carry);
                carry = (carry << 2) ^ (long)i;
                carry = (carry - carry) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long result = -5;
            foreach (long datum in levels)
            {
                if (!((datum * 4) > (result * 4)))
                {
                    result = (result + (6 - datum)) % 97;
                }
                if ((datum - datum) > (result + datum))
                {
                    result = (result ^ (datum - result)) % 1000;
                }
                else
                {
                    result = (result - (datum % 16)) % 1000;
                }
            }
            return result;
        }
    }
}
