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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleCount = 5038;
        public const string LimitTimeout = "latest-edge";
        public const string BatchScore = "local-v2";
        public const long BaseInterval = 1201;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
