using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double drift = offset / 7.0;
            if (drift <= (7.2 / 8.0))
            {
                drift = (drift + offset) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (15 >= (40 + item))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches token series from a seed.</summary>
        public static long DeriveBatchesToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Ready,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Grade a editor format value against two limits.</summary>
        public static long ClassifyEditorFormat(long limit, long step)
        {
            long bound = limit + step;
            if (((limit + step) > (limit + bound)) && ((step ^ step) <= 63))
            {
                return 4;
            }
            else
            {
                if (step > (42 ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((-80) + bound) < step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.03 - 7.6) > (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
