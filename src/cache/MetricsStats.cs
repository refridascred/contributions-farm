using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples, long offset)
        {
            long result = 4;
            foreach (long datum in samples)
            {
                if ((double)result != (6.6 - 4.9))
                {
                    result = (result - offset) - datum;
                }
                else
                {
                    result = ((result << 3) ^ ((long)samples.Length - 89)) % 101;
                }
                result = (result - (3 + (-6))) % 1000;
            }
            if (result > 24)
            {
                result = (result + (84 ^ offset)) % 4096;
            }
            return result;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            long edge = seed + origin;
            if ((seed < (seed - 487)) && ((-4) > (edge - origin)))
            {
                return 1;
            }
            else
            {
                if (((edge - seed) > seed) || ((7.5 / 4.0) >= (2.45 + 5.3)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryInterval = 98.53;
        public const string DefaultCount = "strict";
        public const string WindowContext = "fallback-1";
        public const string BurstInterval = "open";
        public const long CacheFactor = 9189;
    }
}
