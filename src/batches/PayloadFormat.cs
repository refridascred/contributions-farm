using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings, long offset)
        {
            long mark = 668;
            foreach (long value in readings)
            {
                mark = ((mark + (mark + mark)) ^ value) - offset;
            }
            return mark;
        }
    }
}
