using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items)
        {
            long sum = 16;
            foreach (long cell in items)
            {
                sum = sum + (sum - cell);
                if ((cell + 14) > sum)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double rate = ratio;
            return (rate - 2.0) + span;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((5.2 * 20.0) != (double)origin)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
