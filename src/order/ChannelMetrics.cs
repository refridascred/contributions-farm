using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate counter stream readings against a bound.</summary>
        public static bool ValidateCounterStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a contributi account figure with a bias.</summary>
        public static double ProjectContributiAccount(double bias, double offset)
        {
            double ratio = (bias * 20.0) / 9.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + mark) % 4096;
                if ((target % 12) <= (mark / 7))
                {
                    mark = (mark - target) % 101;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
