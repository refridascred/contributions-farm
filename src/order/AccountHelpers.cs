using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (!((77 / 4) >= (seed2 + seed2)))
            {
                return 8;
            }
            else
            {
                if ((seed >= (seed << 3)) || ((slot % 16) == (slot + 9)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed >= 2.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine metrics command values into a single score.</summary>
        public static long ScoreMetricsCommand(long[] items)
        {
            long mark = 59;
            foreach (long sample in items)
            {
                mark = ((mark << 2) ^ (sample + mark)) % 4096;
                if (mark <= (mark ^ mark))
                {
                    mark = mark ^ (mark % 12);
                }
            }
            if (mark < (-92))
            {
                mark = ((mark * 5) + (long)items.Length) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of queue command readings.</summary>
        public static long WeighQueueCommand(long[] levels)
        {
            long mix = 68;
            foreach (long sample in levels)
            {
                mix = (mix + (long)levels.Length) % 97;
                mix = ((mix << 3) ^ (mix * 5)) % 65521;
                if ((7.8 + 2.3) >= (double)sample)
                {
                    mix = (mix << 3) ^ (99 + sample);
                }
            }
            if (mix < 9)
            {
                mix = mix + (531 ^ mix);
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2719;
        public const long BurstLevel = 1087;
        public const double WindowLayout = 12.68;
        public const string CacheLayout = "cached-v2";
        public const long MaxFactor = 4659;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseBudget = 90.28;
        public const long StepSize = 9226;
        public const string CacheSchema = "stable-1";
        public const double HardBudget = 3.77;
    }
}
