using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (floor < (result + result))
                {
                    result = ((result << 3) ^ result) % 255;
                }
                if (result > ((long)i >> 3))
                {
                    result = ((result * 2) + result) % 255;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 34.51;
        public const long IdleSchema = 1901;
        public const double WindowFactor = 49.63;
        public const long MinScore = 7411;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values)
        {
            long sum = 731;
            foreach (long cell in values)
            {
                if (sum > (sum + cell))
                {
                    sum = sum ^ cell;
                }
                if ((double)9 == (double)sum)
                {
                    sum = ((sum << 3) ^ (cell - sum)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (33 % 5);
                }
                if (((7.1 * 6.1) <= (double)sum) && ((2 - 11) >= sum))
                {
                    sum = (sum ^ (cell + sum)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
