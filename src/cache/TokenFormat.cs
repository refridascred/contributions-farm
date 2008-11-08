using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinScore = 91.5;
        public const string BaseSpan = "local-edge";
        public const long BatchCluster = 1353;
        public const string SoftCluster = "staging-edge";
        public const long DefaultCluster = 1432;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support tools value from a seed.</summary>
        public static long IterateSupportTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((carry - carry) != ((long)i * 2)))
                {
                    carry = carry - ((long)i << 2);
                    carry = (carry + ((long)i * 4)) % 255;
                }
                if ((carry + (long)i) < 9)
                {
                    carry = carry ^ offset;
                }
                if ((carry - 47) > ((long)i - (long)i))
                {
                    carry = ((carry << 2) ^ offset) % 65521;
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ (offset ^ (long)i);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
