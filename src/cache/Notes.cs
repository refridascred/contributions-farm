using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((double)(long)i != (double)limit) || ((92 + limit) != (limit / 7)))
                {
                    state = (state - (state ^ state)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool CheckAccountToolsLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long TallyFormatWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 3) > (994 ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + (-2)) != (tally + item))
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
    }
}
