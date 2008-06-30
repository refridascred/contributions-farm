using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            if ((68 + offset) >= (offset / 6))
            {
                return 0;
            }
            else
            {
                if ((seed % 8) > (seed >> 5))
                {
                    return 3;
                }
                else
                {
                    if (seed <= (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = mix - step;
                mix = (mix - (14 >> 3)) % 65521;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
