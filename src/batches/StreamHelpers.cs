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

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if ((double)acc < (double)item)
                {
                    acc = (acc - acc) - offset;
                }
                if (((acc / 3) < (item / 9)) || ((4.0 + 15.0) != (double)acc))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc;
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
