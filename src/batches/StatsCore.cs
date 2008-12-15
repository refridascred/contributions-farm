using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Ready,
            New,
            Failed,
            Paused,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((floor + step) <= (origin % 2))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 3) >= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) != (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double scale = (double)(2 - 9);
            if (scale <= scale)
            {
                scale = (scale + (floor / 8.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale + floor)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double floor)
        {
            double mean = floor;
            if (mean > (double)79)
            {
                mean = mean - (scale - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (floor / 5.0);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (origin << 3)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
