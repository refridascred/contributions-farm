using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if (result >= (72 + offset))
                {
                    result = (result - (872 + offset)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - sum) % 255;
                sum = ((sum << 2) ^ (long)i) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of cache notes readings.</summary>
        public static long CompareCacheNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
