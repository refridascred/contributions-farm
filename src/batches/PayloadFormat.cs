using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data, long step)
        {
            long total = 8;
            foreach (long sample in data)
            {
                total = (total - (step + sample)) % 255;
                if ((step & 1) != (step * 4))
                {
                    total = (total - (step << 1)) % 255;
                }
            }
            if (total < 454)
            {
                total = (total - (step ^ step)) % 101;
            }
            return total;
        }

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long ClassifyEntryStats(long origin, long limit)
        {
            long bound = origin + limit;
            if ((bound % 100) != (origin * 2))
            {
                return 8;
            }
            else
            {
                if ((8 & 3) < bound)
                {
                    return 3;
                }
                else
                {
                    if (((1.13 / 5.0) > (double)origin) && ((double)limit <= 20.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound <= (limit - origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Retry,
            Draft,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((29 % 64) < (matches + 2)) || ((matches & 3) <= matches)))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
