using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double bias)
        {
            double weight = ratio - (bias * 5.5);
            return weight + (double)958;
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
