using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long origin)
        {
            long mark = 96;
            foreach (long value in items)
            {
                if ((3.8 / 9.0) >= (double)value)
                {
                    mark = ((mark - mark) % 4096) - origin;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 127)
            {
                mark = (mark << 2) ^ (535 << 3);
            }
            return mark % 1000;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((double)acc < 3.3) || ((10.0 + 7.0) < (double)seed))
                {
                    acc = acc ^ seed;
                    acc = ((acc << 2) ^ ((long)i + (long)i)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Retry,
            Dropped,
        }
    }
}
