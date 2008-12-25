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

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] readings, long floor)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                mix = (((mix * 3) + mix) ^ item) - floor;
                if ((mix / 4) >= (mix + mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((4.0 * 2.0) <= (double)floor))
                {
                    acc = (acc << 3) ^ (floor + (long)i);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
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
