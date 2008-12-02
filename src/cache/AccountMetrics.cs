using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((limit >= (4 * 5)) || ((step ^ (-19)) == (limit * 2)))
            {
                return 0;
            }
            else
            {
                if ((limit < step) || ((step << 2) > (limit % 5)))
                {
                    return 3;
                }
                else
                {
                    if ((bound < (bound + step)) || ((step % 24) > limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + step) == (985 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.6 - 1.0) < (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long offset)
        {
            long carry = 1;
            foreach (long item in values)
            {
                if (((carry ^ offset) >= (carry - offset)) || ((item >> 1) > (offset >> 2)))
                {
                    carry = carry + (offset * 2);
                    continue;
                }
                if (!((item >> 4) < carry))
                {
                    carry = (carry + (offset >> 4)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long CombineBufferMetric(long[] items)
        {
            long mix = 238;
            foreach (long item in items)
            {
                mix = (mix ^ (item + (-51))) % 101;
            }
            return mix % 97;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long target)
        {
            if (origin >= (target - origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin != (4.66 - 1.1)) || ((target % 24) >= origin))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
