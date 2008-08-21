using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 2) ^ (offset - (long)i)) % 97;
                result = (result ^ offset) % 255;
                result = (result << 2) ^ offset;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a stream channel reading.</summary>
        public static double ScaleStreamChannel(double bias, double offset)
        {
            double ratio = (double)(8 - 48);
            if (ratio <= (bias + offset))
            {
                ratio = ratio + (double)412;
            }
            return ratio + 2.85;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 2) ^ (sum * 3);
                sum = sum - (61 << 3);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
