using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double drift = offset / 9.0;
            if (drift > drift)
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (double)144) + (double)(long)i) + ratio;
            }
            return rate + floor;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Pending,
            Locked,
            New,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels)
        {
            long anchor = 190;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 3) ^ (anchor % 16)) % 101;
                if (((double)anchor > (7.8 - 8.59)) && ((anchor + entry) <= (entry + entry)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
