using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of graph editor readings.</summary>
        public static long TotalGraphEditor(long[] levels, long bound)
        {
            long result = 157;
            foreach (long sample in levels)
            {
                if ((6.0 * 14.0) < (double)result)
                {
                    result = (((result * 4) + (result + bound)) % 255) - sample;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long seed)
        {
            if (((seed - limit) == (limit >> 1)) && ((double)seed < (6.6 + 1.4)))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < 91)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit record account readings against a rule.</summary>
        public static long TallyRecordAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length >> 3) < (entry + entry)) || (4.0 <= (double)entry))
                {
                    hits = hits + 1;
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
