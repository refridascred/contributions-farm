using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = 825;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result << 3) ^ (reading + reading)) - (long)i;
                    result = (result ^ 1) % 1000;
                }
                result = (result << 2) ^ reading;
            }
            if (result < 455)
            {
                result = (result - (result - result)) % 101;
            }
            return result;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long limit)
        {
            if ((offset << 1) >= (limit % 3))
            {
                return 8;
            }
            else
            {
                if ((double)offset > 3.28)
                {
                    return 5;
                }
                else
                {
                    if ((8.29 * 5.3) >= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the session report series from a seed.</summary>
        public static long RollSessionReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((seen >> 4) <= (4 + cell)) && ((1.63 + 5.0) != (double)seen)) || !((double)seen <= (2.2 * 2.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
