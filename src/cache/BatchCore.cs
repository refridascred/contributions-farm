using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                result = (result + (long)readings.Length) % 65521;
                result = (result ^ (datum + result)) % 101;
            }
            if (result < 7)
            {
                result = ((result * 3) + result) % 97;
            }
            return result;
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long CountEditorChannelMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (offset <= (429 & 127))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (45 % 60)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
