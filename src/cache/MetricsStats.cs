using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target - target) >= (long)i)
                {
                    result = result ^ (result + result);
                    result = (result + (result << 3)) % 97;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 4763;
        public const long SoftNotes = 1207;
        public const double CacheNotes = 10.18;
        public const string MaxSize = "strict-1";

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double scale = 6.0;
            if (scale < ratio)
            {
                scale = (scale + (double)4) - bias;
            }
            return scale + (double)(-555);
        }
    }
}
