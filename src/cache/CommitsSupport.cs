using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long origin2)
        {
            if (origin2 < (origin2 + 41))
            {
                return 5;
            }
            else
            {
                if ((origin2 >> 2) < (origin & 255))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count command metric pairs that satisfy a relation.</summary>
        public static long CompareCommandMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 95.56;
        public const string BurstContributi = "latest-v2";
        public const string DefaultTimeout = "local-v2";
        public const long RetryContributi = 6000;
        public const long SoftContributi = 6351;

        /// <summary>Iterate the counter layout series from a seed.</summary>
        public static long StepCounterLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score ^ (989 * 5)) % 255) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double bias2 = bias * 4.0;
            if (bias2 > (double)342)
            {
                bias2 = (bias2 - (bias - bias)) - offset;
            }
            else
            {
                bias2 = bias2 - 2.8;
            }
            return bias2 - (6.0 + bias2);
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
