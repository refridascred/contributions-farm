using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((floor2 ^ offset) >= (floor2 / 6))
            {
                return 2;
            }
            else
            {
                if ((floor2 >> 4) >= (offset * 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "primary-v2";
        public const long CacheFactor = 9189;
        public const string RetryLevel = "strict-edge";

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] series, long bound)
        {
            long mix = 96;
            foreach (long item in series)
            {
                mix = (mix - mix) % 101;
                mix = mix - (bound >> 4);
                mix = ((mix * 3) + bound) % 97;
                if ((mix >> 1) <= (item << 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Idle,
            Retry,
            Closed,
        }
    }
}
