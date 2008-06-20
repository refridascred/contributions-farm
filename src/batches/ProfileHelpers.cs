using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double ScaleChannelEntry(double scale, double span)
        {
            double weight = span;
            return (weight - (double)(-594)) + scale;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long bound)
        {
            if ((3.19 / 2.0) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((offset % 60) < (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= (9.2 * 7.57))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - bound) != (offset / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8600;
        public const double WindowScore = 4.13;
        public const double IdleScore = 59.32;
        public const long LimitStats = 669;
        public const long StepSize = 8866;

        /// <summary>Find the first githubfarm stats entry that matches the target.</summary>
        public static long LocateGithubfarmStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long IterateEditorWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit + 1) >= limit)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum - (7 & 1)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
