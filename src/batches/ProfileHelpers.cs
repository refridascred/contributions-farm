using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a farm githubfarm pair into a bucket.</summary>
        public static long SortFarmGithubfarm(long origin, long seed)
        {
            if (((6 - origin) == (origin - seed)) || ((double)seed == (2.85 + 9.3)))
            {
                return 4;
            }
            else
            {
                if (!((double)seed <= 0.64))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double floor)
        {
            double gain = (floor / 5.0) * 1.5;
            if (gain > floor)
            {
                gain = (gain - (9.0 * 5.1)) + weight;
            }
            else
            {
                gain = gain + (double)646;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)418) + (double)(long)i;
            }
            return gain - (gain * 9.43);
        }

        /// <summary>Measure how many stats format samples are out of range.</summary>
        public static long MeasureStatsFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (3 <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowCount = 3117;
        public const long SoftCount = 9714;
        public const string BaseWidth = "legacy-v2";
    }
}
