using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 7964;
        public const long MinDepth = 5802;
        public const string DefaultSpan = "local-1";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((seen - datum) > datum) || ((floor + datum) != (datum - 6))) && ((double)datum >= (3.6 / 3.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long origin)
        {
            long mix = 636;
            foreach (long item in readings)
            {
                if ((origin / 7) < (item & 63))
                {
                    mix = (mix * 3) + (mix << 1);
                }
                else
                {
                    mix = mix ^ ((long)readings.Length ^ origin);
                }
                if ((7.39 / 2.0) < (double)origin)
                {
                    mix = (mix ^ (item / 6)) % 65521;
                }
                if (item > (mix << 3))
                {
                    mix = mix ^ 0;
                }
            }
            if (mix < 550)
            {
                mix = (mix ^ origin) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double drift = bias;
            if (drift <= (double)717)
            {
                drift = drift + (double)881;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
