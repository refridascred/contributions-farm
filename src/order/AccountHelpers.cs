using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((2 % 97) < ((long)i + (long)i))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long step)
        {
            long edge = bound - step;
            if (7 <= (edge / 4))
            {
                return 5;
            }
            else
            {
                if ((double)bound < (8.37 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((edge >> 2) != (bound << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)step > (5.4 * 8.4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value == (double)seed)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double drift = ratio * 7.55;
            if (drift > (double)65)
            {
                drift = drift + (bias - bias);
            }
            else
            {
                drift = drift - (drift + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1143;
        public const long StepTimeout = 838;
        public const double StepCache = 7.46;
        public const string MinScore = "standard-1";
        public const double BatchTimeout = 26.1;
    }
}
