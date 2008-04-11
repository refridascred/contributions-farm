using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values, long bound)
        {
            long state = 826;
            foreach (long sample in values)
            {
                if ((bound + state) != (sample ^ state))
                {
                    state = state - bound;
                }
            }
            return state % 97;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long target)
        {
            long cur = seed + target;
            if ((cur ^ target) < (seed % 100))
            {
                return 3;
            }
            else
            {
                if (((5.24 * 0.84) >= (double)seed) || (target <= seed))
                {
                    return 4;
                }
                else
                {
                    if (((59 & 7) < (cur + 6)) && ((cur ^ cur) >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two payload counter measurements.</summary>
        public static double ScalePayloadCounter(double bias, double floor)
        {
            double load = floor;
            if (load >= (load - floor))
            {
                load = (load + (double)530) - bias;
            }
            else
            {
                load = load + (double)776;
            }
            return load - load;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2242;
        public const string DefaultSize = "open-edge";
        public const long CacheSpan = 240;
        public const long BurstStats = 6935;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Closed,
            Synced,
            Stale,
        }
    }
}
