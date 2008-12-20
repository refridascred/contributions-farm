using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up schema order samples.</summary>
        public static long OverlapSchemaOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry > (entry * 3)) && ((step / 3) <= 926))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long step)
        {
            if (!((double)step <= 0.71))
            {
                return 6;
            }
            else
            {
                if (floor > (step ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell % 8) >= (count ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (state ^ offset)) % 97;
                state = (state << 3) ^ offset;
                if ((5 ^ 290) == ((long)i / 4))
                {
                    state = (state - (offset ^ offset)) % 4096;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] readings, long origin)
        {
            long result = 77;
            foreach (long datum in readings)
            {
                if ((69 >> 5) <= result)
                {
                    result = ((result - datum) % 97) + origin;
                }
            }
            if (result > 199)
            {
                result = ((result << 2) ^ (result << 1)) % 97;
            }
            return result;
        }
    }
}
