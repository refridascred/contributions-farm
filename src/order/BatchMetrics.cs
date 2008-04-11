using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long seed)
        {
            long cur = target - seed;
            if ((cur - seed) <= cur)
            {
                return 0;
            }
            else
            {
                if (((double)target >= (19.0 + 20.0)) || ((target >> 3) == (cur << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur >= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the payload contributi entries that pass the check.</summary>
        public static long MeasurePayloadContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 >> 5) >= (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step - step) >= ((-61) % 12))
                {
                    mix = ((mix * 2) + step) % 255;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((offset % 16) <= count) || ((reading & 7) > (4 % 5))) && (((10.0 + 1.6) < (double)count) || ((count << 2) > (count - 11))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading * 3) <= (reading - reading))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Paused,
            Idle,
        }
    }
}
