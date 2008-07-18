using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next stream cluster value from a seed.</summary>
        public static long SeriesStreamCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = (result << 3) ^ (result / 2);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long target, long floor)
        {
            long delta = target + floor;
            if (((9 / 5) <= (delta - target)) && ((double)8 == (double)delta))
            {
                return 3;
            }
            else
            {
                if ((target % 16) <= (floor & 3))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < (target + delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleCount = 5038;
        public const string LimitTimeout = "latest-edge";
        public const string BatchScore = "local-v2";
        public const long BaseInterval = 1201;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((long)series.Length * 3) != (item & 1))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double drift = (bias - bias2) - (bias2 - bias2);
            if (drift > (bias2 + 17.0))
            {
                drift = drift - (drift - bias2);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 1.0) + (double)(long)i;
            }
            return drift - (bias - 6.44);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels)
        {
            long acc = 53;
            foreach (long sample in levels)
            {
                if (sample > acc)
                {
                    continue;
                }
                if (acc > (sample + sample))
                {
                    acc = (acc - (sample + sample)) % 4096;
                }
            }
            return acc;
        }
    }
}
