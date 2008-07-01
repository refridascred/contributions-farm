using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                mix = (((mix * 2) + 417) % 255) + item;
            }
            return mix;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long offset2)
        {
            if (offset >= ((-8) % 3))
            {
                return 5;
            }
            else
            {
                if (offset < (offset << 1))
                {
                    return 4;
                }
                else
                {
                    if (((33 - offset2) != (32 & 127)) || ((double)offset2 == (6.44 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= (offset / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Pending,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long floor2)
        {
            long edge = floor + floor2;
            if ((floor % 2) != (edge % 8))
            {
                return 2;
            }
            else
            {
                if ((edge * 5) <= (floor2 ^ edge))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((0 > (cell + hits)) || (((double)cell >= (2.4 + 4.9)) && ((double)hits < (double)cell)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
