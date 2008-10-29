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

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                if ((score + sample) != (score * 5))
                {
                    score = (score - ((-1) - sample)) % 1000;
                }
            }
            return score;
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
