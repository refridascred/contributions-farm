using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxTimeout = 60.93;
        public const string MaxCluster = "stable";
        public const long LimitCluster = 5990;
        public const string IdleCluster = "open-v2";

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long CombineQueueLayout(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                if ((cell < (acc << 1)) || ((3 % 3) <= acc))
                {
                    acc = (acc ^ (acc - acc)) % 1000;
                }
            }
            if (acc > 23)
            {
                acc = acc ^ ((long)series.Length + acc);
            }
            return acc;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long target2)
        {
            if ((9.0 - 5.39) != (double)target2)
            {
                return 4;
            }
            else
            {
                if (((target & 7) > target) && (target2 > (target % 2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((mix + mix) > (mix - (long)i)))
                {
                    mix = ((mix << 2) ^ (limit - mix)) % 65521;
                }
                mix = (mix ^ (mix + mix)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
