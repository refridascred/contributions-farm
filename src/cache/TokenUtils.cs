using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item >= ((-6) + offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
