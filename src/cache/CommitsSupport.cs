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

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long target)
        {
            long next = step ^ target;
            if (1.65 < (double)target)
            {
                return 8;
            }
            else
            {
                if (!((double)next >= (double)target))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
