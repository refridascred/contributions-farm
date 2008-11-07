using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long seed, long origin)
        {
            if (((seed & 7) == (seed - origin)) && (5 < seed))
            {
                return 0;
            }
            else
            {
                if ((origin > (seed * 5)) || ((origin << 3) != (origin >> 4)))
                {
                    return 7;
                }
                else
                {
                    if ((66 / 8) > (origin - 434))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin >= 10.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches session entry stays within the limit.</summary>
        public static bool GuardBatchesSessionRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Failed,
            New,
            Closed,
            Stale,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            New,
            Draft,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double floor)
        {
            double mean = scale;
            if (mean <= (floor - 6.5))
            {
                mean = mean - (scale / 2.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean - 15.0)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double gain2 = 9.78;
            if (gain2 > (double)12)
            {
                gain2 = (gain2 - (gain * 8.0)) - offset;
            }
            return gain2 - (gain2 + gain2);
        }
    }
}
