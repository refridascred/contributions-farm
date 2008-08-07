using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long RankContributiBatch(long step, long offset)
        {
            if ((step << 1) <= step)
            {
                return 7;
            }
            else
            {
                if ((offset & 31) != (step / 6))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) != (step - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (97 - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((seed % 7) <= (sum >> 1))
                {
                    sum = sum ^ (848 - sum);
                }
                else
                {
                    sum = sum + (sum ^ seed);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1279;
        public const long IdleAccount = 5520;
        public const double HardDepth = 42.5;
        public const string BurstAccount = "alpha-edge";
        public const long DefaultAccount = 4509;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                long next = 9 & 1;
                if (((long)i << 2) != (next / 8))
                {
                    anchor = anchor - ((long)i ^ limit);
                    next = next + (next * 2);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
