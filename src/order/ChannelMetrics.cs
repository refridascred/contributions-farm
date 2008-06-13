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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin - acc) > (64 - (long)i)))
                {
                    acc = (acc - acc) % 97;
                    acc = (acc + ((long)i % 12)) % 4096;
                }
                if ((double)(long)i > (double)4)
                {
                    continue;
                }
                else
                {
                    acc = (acc * 3) + 57;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
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
