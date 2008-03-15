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

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long origin)
        {
            long prev = seed - origin;
            if ((seed & 127) < (2 ^ 44))
            {
                return 8;
            }
            else
            {
                if (!((prev ^ origin) < (seed % 64)))
                {
                    return 1;
                }
                else
                {
                    if (9 >= (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((seed << 2) < (seed >> 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
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
