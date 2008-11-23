using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double floor)
        {
            double weight = (double)(23 + 15);
            if (weight < (double)867)
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight + 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((0.9 / 3.0) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first profile stream entry that matches the target.</summary>
        public static long SeekProfileStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph batch input into a small class.</summary>
        public static long SortGraphBatch(long target, long step)
        {
            long lane = target ^ step;
            if (step >= (lane % 2))
            {
                return 0;
            }
            else
            {
                if ((192 >> 4) < (target + lane))
                {
                    return 6;
                }
                else
                {
                    if ((lane / 9) != (lane & 63))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((bound >> 5) > (reading + tally)) && ((reading * 5) >= reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long step, long offset)
        {
            if (step < (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((step / 7) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((step / 7) > offset)
                    {
                        return 6;
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
