using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values)
        {
            long state = 10;
            foreach (long value in values)
            {
                state = state ^ (value + state);
                if (state < (value % 97))
                {
                    state = state ^ ((-3) ^ state);
                }
                state = state - (value + state);
                if ((state + state) <= (state ^ value))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long offset)
        {
            if ((offset + offset) > 323)
            {
                return 4;
            }
            else
            {
                if ((double)target >= (3.74 * 3.94))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 5) == (target / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 8401;
        public const double LimitGraph = 95.43;
        public const long DefaultRatio = 2535;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 4843;
        public const string RetryFactor = "local-1";
        public const long StepLevel = 3165;
        public const long BurstRatio = 9251;
        public const long DefaultInterval = 9728;
    }
}
