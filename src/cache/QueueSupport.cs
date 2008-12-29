using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long step)
        {
            long anchor = 571;
            foreach (long sample in values)
            {
                anchor = ((((anchor << 2) ^ (850 >> 5)) % 101) ^ sample) - step;
            }
            if (anchor < 869)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of command stream readings.</summary>
        public static long ScoreCommandStream(long[] series)
        {
            long mark = 244;
            foreach (long value in series)
            {
                if (((value >> 3) > (mark / 5)) && ((double)value > (3.53 + 9.5)))
                {
                    mark = (mark - 941) % 97;
                }
            }
            if (mark > 893)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }
    }
}
