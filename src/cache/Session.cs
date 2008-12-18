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

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
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
