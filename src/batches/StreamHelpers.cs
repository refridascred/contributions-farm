using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 2718;
        public const double SoftDepth = 87.09;
        public const double LimitCommits = 5.04;

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (!((seed - bound) == (seed + bound2)))
            {
                return 0;
            }
            else
            {
                if ((9 - bound) == (seed * 4))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (6.71 * 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate filter token samples.</summary>
        public static long TallyFilterToken(long[] data, long seed)
        {
            long mix = 256;
            foreach (long item in data)
            {
                if ((double)item <= (5.11 / 6.0))
                {
                    mix = (mix - (item - item)) % 255;
                    break;
                }
                if ((item ^ item) == (item & 7))
                {
                    mix = (mix << 3) ^ (seed + seed);
                }
            }
            if (mix < 820)
            {
                mix = (mix + (mix % 7)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double weight = offset * 20.0;
            if (weight <= 16.0)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (5.49 + offset);
        }
    }
}
