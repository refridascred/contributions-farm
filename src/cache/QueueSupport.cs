using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((327 + entry) == ((long)data.Length - hits)) || (((double)hits != (4.52 * 5.6)) && ((entry % 60) >= ((-7) % 7))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long step)
        {
            if (step < (step >> 1))
            {
                return 6;
            }
            else
            {
                if ((74 + origin) <= (origin - origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] samples)
        {
            long mix = 71;
            foreach (long datum in samples)
            {
                if ((double)mix > (3.7 - 4.1))
                {
                    mix = (mix << 3) ^ (datum ^ (long)samples.Length);
                }
                if ((150 << 2) > (datum >> 4))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
