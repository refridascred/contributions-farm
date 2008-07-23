using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch buffer readings against a rule.</summary>
        public static long MeasureBatchBufferGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)count == (3.6 / 4.0)))
                {
                    count = ((count + 1) + cell) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items)
        {
            long state = 8;
            foreach (long datum in items)
            {
                state = state - (datum - datum);
                state = (state ^ datum) % 1000;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "alpha-v2";
        public const long MaxSpan = 5524;
        public const long LimitCache = 406;
        public const double StepInterval = 14.45;
        public const string BaseCache = "stable-v2";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
