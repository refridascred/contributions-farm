using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of schema route entries.</summary>
        public static long CombineSchemaRoute(long[] items)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                anchor = (anchor - (843 << 1)) + entry;
            }
            if (anchor < 71)
            {
                anchor = (anchor + (803 << 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a counter checks value against two limits.</summary>
        public static long BucketCounterChecks(long origin, long bound)
        {
            long prev = origin - bound;
            if ((9.8 / 4.0) != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin > (prev * 4)) && ((16.0 + 0.46) > (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) <= (origin / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] values, long step)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (((carry * 5) + (carry ^ step)) % 255) - entry;
                if ((step & 31) > (carry + 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Active,
            Queued,
        }
    }
}
