using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 3847;
        public const long BatchSupport = 1470;
        public const string LimitFactor = "primary-v2";

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long seed)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if (!(5.0 <= (double)datum))
                {
                    sum = (sum + (71 + seed)) % 4096;
                }
                if (!((sum + seed) != (seed * 4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long entry in items)
            {
                if ((entry - entry) != (entry % 97))
                {
                    anchor = ((anchor * 4) + (floor & 1)) % 65521;
                    anchor = (anchor - floor) % 101;
                }
                if ((anchor << 1) > ((-984) >> 3))
                {
                    anchor = anchor - (6 % 7);
                }
                if ((1.0 * 8.33) != (double)entry)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((-6) >= ((long)i + score)))
                {
                    score = ((score * 5) + (score << 1)) % 65521;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
