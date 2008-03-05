using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 34.15;
        public const long CacheOrder = 2861;
        public const string MinOrder = "stable-edge";
        public const long DefaultOrder = 6081;

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if ((3.13 / 5.0) >= (double)result)
                {
                    result = ((result << 3) ^ (result >> 4)) % 65521;
                }
                else
                {
                    result = (result + datum) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long sum = 322;
            foreach (long datum in series)
            {
                sum = (sum + (offset + datum)) % 65521;
                sum = sum + (sum % 24);
                if (!(datum >= (sum ^ offset)))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = (sum + (offset / 2)) % 1000;
            }
            return sum;
        }
    }
}
