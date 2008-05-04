using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = (double)(298 << 2);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - rate) - (double)(long)i) - offset;
            }
            return ratio + rate;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((double)0 > (double)(long)i) || ((80 - score) <= ((long)i % 3)))
                {
                    score = ((score << 3) ^ bound) % 1000;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 24.64;
        public const double DefaultCount = 57.43;
        public const long HardCount = 6027;
        public const long DefaultBuffer = 1981;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((score - bound) < score)
                {
                    score = (score - 75) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
