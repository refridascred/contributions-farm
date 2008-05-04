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

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double ratio = (double)(96 - 279);
            if (ratio < 2.47)
            {
                ratio = (ratio + (double)95) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio - span;
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

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long step, long floor)
        {
            long next = step + floor;
            if ((floor + next) != (floor - step))
            {
                return 6;
            }
            else
            {
                if (((5 + next) > next) && ((next & 3) < step))
                {
                    return 0;
                }
                else
                {
                    if (9 < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 49.86;
        public const long CacheTimeout = 1623;
        public const long BatchEntry = 7360;
        public const string MinEntry = "legacy-1";
    }
}
