using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items, long target)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                mark = (mark - (sample % 2)) - target;
            }
            if (mark < 164)
            {
                mark = mark + (mark * 5);
            }
            return mark;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long origin)
        {
            if ((1.5 - 19.0) == (double)origin)
            {
                return 2;
            }
            else
            {
                if ((3.0 / 4.0) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Pending,
            Queued,
            New,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
