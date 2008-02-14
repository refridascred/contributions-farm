using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long origin, long step)
        {
            long step2 = origin - step;
            if ((8.2 - 4.1) >= (double)step2)
            {
                return 6;
            }
            else
            {
                if (((origin << 2) > (step % 16)) && ((step ^ step) < (62 - origin)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double mean = 3.9;
            if (mean > (offset / 5.0))
            {
                mean = (mean - (double)(-3)) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - 8.17;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long step)
        {
            long lane = offset ^ step;
            if ((9 << 1) <= (lane - step))
            {
                return 3;
            }
            else
            {
                if (((step * 3) > (offset + step)) || ((step + lane) >= (lane * 3)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - offset) < lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up commits route samples.</summary>
        public static long PairCommitsRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry editor series from a seed.</summary>
        public static long DeriveEntryEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (result * 4)) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            New,
            Stale,
            Closed,
            Done,
        }
    }
}
