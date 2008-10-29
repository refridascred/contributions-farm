using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinInterval = 13.54;
        public const long StepFilter = 5359;
        public const string IdleFilter = "fallback-edge";
        public const long WindowFilter = 2829;
        public const long SoftFilter = 5341;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if (18 >= (bound + 98))
            {
                return 0;
            }
            else
            {
                if ((limit + bound) >= (66 + limit))
                {
                    return 2;
                }
                else
                {
                    if (115 > (bound >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long target)
        {
            long total = 51;
            foreach (long reading in series)
            {
                total = ((total << 2) ^ (target + 88)) % 1000;
                if ((reading + reading) > (target & 15))
                {
                    break;
                }
            }
            if (total < (-5))
            {
                total = total - total;
            }
            return total % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
