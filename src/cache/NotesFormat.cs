using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value & 7) >= (limit + seen)) || ((limit * 5) > 73))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series)
        {
            long result = 5;
            foreach (long cell in series)
            {
                if ((result * 3) == (cell & 7))
                {
                    result = result ^ (cell - result);
                }
                if ((4.0 * 1.0) > (double)result)
                {
                    result = (result ^ (cell - result)) % 255;
                }
                else
                {
                    result = (result ^ (cell - cell)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
