using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long ScoreChannelProfile(long[] readings, long bound)
        {
            long mix = 78;
            foreach (long reading in readings)
            {
                if ((9 % 100) == (mix - reading))
                {
                    mix = mix ^ (reading - 2);
                }
                else
                {
                    mix = mix - (mix ^ mix);
                }
                if ((bound << 3) < (reading + 527))
                {
                    break;
                }
            }
            if (mix < 138)
            {
                mix = (mix * 4) + (bound - mix);
            }
            return mix;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Combine already metrics values into a single score.</summary>
        public static long FoldAlreadyMetrics(long[] levels)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                mix = (mix + cell) % 255;
            }
            return mix % 1000;
        }
    }
}
