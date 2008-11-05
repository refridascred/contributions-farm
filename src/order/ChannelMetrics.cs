using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ ((long)i + origin);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of farm tools readings.</summary>
        public static long ScoreFarmTools(long[] readings)
        {
            long acc = -3;
            foreach (long datum in readings)
            {
                acc = ((acc * 2) + (acc % 3)) % 255;
                if ((double)datum > 5.9)
                {
                    acc = ((acc << 2) ^ (datum % 5)) % 101;
                }
                if ((datum - datum) >= (acc / 8))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
