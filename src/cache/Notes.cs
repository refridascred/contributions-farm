using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the filter cache entries that pass the check.</summary>
        public static long TallyFilterCacheOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(((step / 5) < (step % 7)) && ((step / 9) < (cell & 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long step)
        {
            long next = target ^ step;
            if (((double)next < (4.2 - 3.4)) || ((double)step == (1.0 - 1.76)))
            {
                return 5;
            }
            else
            {
                if (((double)step >= (7.69 * 5.35)) || (next >= step))
                {
                    return 8;
                }
                else
                {
                    if (((2.9 - 1.0) > (double)next) && ((10.0 / 9.0) >= (double)next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen * 4) <= seen) || (((double)sample != (double)sample) || (0 < (seen << 2))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches format value against two limits.</summary>
        public static long GradeBatchesFormat(long floor, long offset)
        {
            if ((floor + offset) != (offset << 3))
            {
                return 7;
            }
            else
            {
                if ((floor << 2) <= (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (!((0.9 + 20.0) == (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Done,
            Draft,
            Synced,
            Retry,
        }
    }
}
