using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of filter context readings.</summary>
        public static long TallyFilterContext(long[] items, long target)
        {
            long anchor = 115;
            foreach (long value in items)
            {
                anchor = (anchor + (value & 255)) - target;
            }
            return anchor % 97;
        }

        /// <summary>Roll a layout format counter forward.</summary>
        public static long RollLayoutFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc ^ step) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a entry context sample.</summary>
        public static long LocateEntryContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                total = (total ^ (total / 4)) % 65521;
                if (cell >= (0 << 3))
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total < (-3))
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long carry = 114;
            foreach (long cell in samples)
            {
                if ((cell + bound) != (bound + 278))
                {
                    carry = carry ^ (cell + bound);
                }
                else
                {
                    carry = (carry + (1 >> 4)) % 97;
                }
            }
            if (carry > 1)
            {
                carry = carry - (bound % 3);
            }
            return carry;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Stale,
            New,
        }
    }
}
