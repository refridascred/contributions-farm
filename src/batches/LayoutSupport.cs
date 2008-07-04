using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long limit2)
        {
            if ((double)91 < (double)limit2)
            {
                return 2;
            }
            else
            {
                if (((double)limit >= (2.3 - 7.5)) && ((limit / 7) >= limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a notes account reading by value.</summary>
        public static long LocateNotesAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings, long origin)
        {
            long anchor = -27;
            foreach (long reading in readings)
            {
                if (origin >= (origin - 5))
                {
                    anchor = (anchor + reading) % 101;
                    anchor = (anchor ^ anchor) % 4096;
                }
                if ((double)(long)readings.Length == (8.9 + 4.0))
                {
                    anchor = anchor + (origin - 457);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long offset)
        {
            long result = 3;
            foreach (long cell in items)
            {
                result = ((((result << 3) ^ (503 >> 1)) % 101) + cell) - offset;
            }
            return result;
        }
    }
}
