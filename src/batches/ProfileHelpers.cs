using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Failed,
            Idle,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally ^ cell) == (tally * 5))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)origin <= (3.8 / 5.0)))
                {
                    result = (result << 2) ^ (result / 8);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if (9.0 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) != (bound ^ (-2)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)tally >= (19.0 - 0.2)) || (((bound * 4) < (bound % 64)) && ((bound * 3) == (bound - item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
