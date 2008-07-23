using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long step)
        {
            long mix = 741;
            foreach (long entry in levels)
            {
                if ((mix % 60) > mix)
                {
                    mix = mix ^ ((-2) % 97);
                    mix = mix - ((-8) + mix);
                }
                if ((step >> 3) > (77 - step))
                {
                    mix = (mix * 4) + entry;
                }
            }
            if (mix < 8)
            {
                mix = ((mix * 5) + mix) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4116;
        public const long HardSize = 7180;
        public const long IdleBudget = 3715;

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitLevel = 68.22;
        public const long LimitCount = 4955;
        public const long RetryContext = 3144;
        public const long DefaultLevel = 7961;
        public const long WindowBudget = 895;

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long total = 419;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = ((total * 5) + (total / 2)) - (long)i;
                    total = (total + (41 << 1)) % 1000;
                }
                if (!((8 + total) == (total << 3)))
                {
                    total = total + (9 + datum);
                    total = (total + (datum >> 5)) % 255;
                }
                if ((double)datum <= 3.17)
                {
                    total = total + (datum % 5);
                }
                else
                {
                    total = (total * 3) + (4 + total);
                }
                if (((694 & 3) >= (total % 3)) || ((39 & 63) < (long)levels.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ 69;
                mark = mark - (target ^ mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
