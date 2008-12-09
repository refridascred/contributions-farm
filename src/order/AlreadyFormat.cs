using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many tools channel samples are out of range.</summary>
        public static long AuditToolsChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)tally == (0.8 / 4.0)) || (tally <= (sample % 100)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a order context pair into a bucket.</summary>
        public static long SortOrderContext(long target, long seed)
        {
            long next = target + seed;
            if (93 <= (seed + next))
            {
                return 7;
            }
            else
            {
                if ((target + 325) >= next)
                {
                    return 1;
                }
                else
                {
                    if ((2.0 / 9.0) < (17.0 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((332 & 7) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long carry = 0;
            foreach (long item in values)
            {
                carry = ((carry ^ 934) + item) + seed;
                carry = (carry - 83) % 101;
            }
            return carry % 97;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits / 3) == (cell - 179))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
