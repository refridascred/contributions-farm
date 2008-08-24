using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (step - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long limit)
        {
            if ((limit & 255) != (44 >> 2))
            {
                return 0;
            }
            else
            {
                if (((offset % 7) < limit) || ((2 - offset) < offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 3) >= (limit - 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < 421)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
