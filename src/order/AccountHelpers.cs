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

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long step)
        {
            if ((seed + step) != (step - seed))
            {
                return 6;
            }
            else
            {
                if (step >= 7)
                {
                    return 4;
                }
                else
                {
                    if (65 >= (seed & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
