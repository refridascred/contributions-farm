using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepSpan = 4500;
        public const double CacheTimeout = 32.24;
        public const long MinLevel = 6896;

        /// <summary>Count already context pairs that satisfy a relation.</summary>
        public static long PairAlreadyContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 71;
            foreach (long reading in values)
            {
                if ((double)reading <= (14.0 * 3.55))
                {
                    acc = (acc + reading) % 65521;
                }
                if (((double)acc >= 6.53) && ((acc - acc) > (986 & 31)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a buffer support reading by value.</summary>
        public static long LookupBufferSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
