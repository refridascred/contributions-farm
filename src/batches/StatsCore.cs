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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches >= (9.86 + 9.64))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long floor2)
        {
            if (((floor / 4) <= (floor2 % 100)) || (floor > (829 / 5)))
            {
                return 8;
            }
            else
            {
                if (((double)floor2 == (double)floor) || (floor < (7 & 3)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (1.0 - 7.08))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-732) * 2) <= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
