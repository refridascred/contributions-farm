using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + item) != (item * 2))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((mix ^ origin) != ((long)i - origin))
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 4096;
                    break;
                }
                if (!((2.85 / 5.0) != (double)origin))
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Done,
            Idle,
            Failed,
        }
    }
}
