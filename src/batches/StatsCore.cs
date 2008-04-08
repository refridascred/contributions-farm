using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally / 5) > tally) || ((56 % 24) > (14 + tally)))
                {
                    tally = ((tally + 3) - cell) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!(1.27 >= (double)(long)i))
                {
                    state = ((state << 3) ^ (state - 325)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double load = (double)(40 + 271);
            if (load <= weight)
            {
                load = load + (weight + load);
            }
            else
            {
                load = load - span;
            }
            return load + (double)96;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 4) == (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
