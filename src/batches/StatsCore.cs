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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Adjust a stream payload reading.</summary>
        public static double SmoothStreamPayload(double rate, double span)
        {
            double ratio = (rate * 9.1) * 4.6;
            if (ratio <= (double)390)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio - (double)5;
        }
    }
}
