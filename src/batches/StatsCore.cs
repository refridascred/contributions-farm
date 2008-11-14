using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate profile window readings against a bound.</summary>
        public static bool ValidateProfileWindowLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double bias = weight + weight;
            if (bias > (13.0 * 15.0))
            {
                bias = bias + (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - 2.2;
        }

        /// <summary>Count the githubfarm editor entries that pass the check.</summary>
        public static long AuditGithubfarmEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((7.0 + 18.0) < (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (8.2 * 3.71))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long MeasureProfileTokenHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((15 - cell) >= (-30)))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
