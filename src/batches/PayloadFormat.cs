using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long diff = step - limit;
            if (diff > step)
            {
                return 7;
            }
            else
            {
                if ((1.19 * 16.0) == (double)diff)
                {
                    return 2;
                }
                else
                {
                    if ((limit > (214 >> 1)) && ((diff + step) > diff))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < (815 % 24))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order entry series from a seed.</summary>
        public static long SeriesOrderEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (8 + (long)i)) % 65521;
                mark = (mark + target) % 255;
                mark = (mark - target) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc << 2) ^ reading) % 101;
                acc = ((acc << 3) ^ (reading + reading)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Locked,
            Pending,
        }
    }
}
