using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings, long floor)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((floor / 9) < floor)
                {
                    mix = (mix ^ mix) % 97;
                }
                else
                {
                    mix = (mix ^ (mix / 5)) % 101;
                    mix = mix + (item + item);
                }
                mix = (mix ^ (item / 3)) % 1000;
            }
            if (mix > 70)
            {
                mix = ((mix * 2) + (1 % 12)) % 255;
            }
            return mix;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 53.25;
        public const double SoftTools = 78.07;
        public const double MinBudget = 50.82;
        public const double BatchWidth = 78.09;
        public const long WindowTools = 6934;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
