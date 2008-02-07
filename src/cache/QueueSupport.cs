using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long target)
        {
            long diff = limit ^ target;
            if ((0 + diff) < (target + limit))
            {
                return 0;
            }
            else
            {
                if ((target - target) > ((-29) % 24))
                {
                    return 3;
                }
                else
                {
                    if (diff <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up command format samples.</summary>
        public static long OverlapCommandFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
