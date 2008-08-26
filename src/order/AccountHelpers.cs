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

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Done,
            New,
            Stale,
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

        /// <summary>Grade a payload cache value against two limits.</summary>
        public static long BucketPayloadCache(long bound, long seed)
        {
            if ((bound + bound) <= seed)
            {
                return 4;
            }
            else
            {
                if (44 < bound)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
