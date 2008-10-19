using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long target)
        {
            long mix = -6;
            foreach (long value in levels)
            {
                if (((double)mix != (11.0 * 7.6)) || ((double)value <= (double)target))
                {
                    mix = (mix * 5) + (target << 3);
                }
                else
                {
                    mix = ((mix * 5) + (value + value)) % 65521;
                }
            }
            if (mix > 941)
            {
                mix = (mix ^ (41 % 60)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long target2)
        {
            long slot = target ^ target2;
            if ((target - 39) >= (6 - 16))
            {
                return 0;
            }
            else
            {
                if (((target + target) <= ((-65) % 60)) || ((slot - 98) >= (target2 % 10)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 + 8.0) <= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long offset)
        {
            if ((5.62 * 7.0) == (double)step)
            {
                return 3;
            }
            else
            {
                if ((step + offset) >= step)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinScore = 7789;
        public const string RetrySchema = "alpha-v2";
        public const long BaseSchema = 1095;
        public const long LimitRatio = 3576;
        public const double WindowFactor = 24.4;
    }
}
