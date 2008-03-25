using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine order account values into a single score.</summary>
        public static long TallyOrderAccount(long[] readings)
        {
            long mark = 628;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + (mark << 3)) % 101;
                if (((double)cell < (double)mark) || ((689 ^ mark) == (cell + mark)))
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > 642)
            {
                mark = mark - mark;
            }
            return mark % 4096;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] levels, long seed)
        {
            long anchor = 265;
            foreach (long value in levels)
            {
                if ((double)seed == (12.0 - 10.0))
                {
                    anchor = (anchor * 4) + (seed - value);
                }
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
