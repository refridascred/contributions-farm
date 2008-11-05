using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score << 2) ^ ((long)i >> 3);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
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
