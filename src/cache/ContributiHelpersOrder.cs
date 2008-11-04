using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count >= (5.06 + 1.8))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue batch input into a small class.</summary>
        public static long RankQueueBatch(long seed, long step)
        {
            long offset = seed ^ step;
            if (((offset + offset) < 424) && ((seed / 2) < (270 + 511)))
            {
                return 7;
            }
            else
            {
                if (offset > (offset + seed))
                {
                    return 6;
                }
                else
                {
                    if ((offset + 66) > (step << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
