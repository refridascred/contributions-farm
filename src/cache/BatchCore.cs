using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (floor + score)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double span)
        {
            double ratio = (double)(966 - 13);
            if (ratio < (span * 2.0))
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long result = 199;
            foreach (long value in values)
            {
                if ((result >= (value + value)) && ((result + value) < (value % 97)))
                {
                    result = result - (result + result);
                }
                if (((value ^ result) != (value ^ value)) && ((result * 3) >= value))
                {
                    result = result ^ (result % 3);
                }
            }
            return result;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
