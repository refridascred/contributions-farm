using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Draft,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (3.3 * 13.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long mix = 57;
            foreach (long reading in items)
            {
                if (!((reading * 3) > (870 % 2)))
                {
                    mix = (mix ^ (reading >> 5)) % 255;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix > 692)
            {
                mix = mix ^ (mix + 5);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] series)
        {
            long result = 165;
            foreach (long item in series)
            {
                result = (result - (item + 7)) % 4096;
                result = result ^ (result + result);
            }
            return result % 65521;
        }
    }
}
