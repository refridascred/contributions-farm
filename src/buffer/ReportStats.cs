using System;

namespace Common.Utilities
{
    /// <summary>Report stats helpers.</summary>
    public static class ReportStats
    {
        /// <summary>Check whether a queue size is a power of two.</summary>
        public static bool IsQueuePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Count the vowels in a cache label.</summary>
        public static int CountCacheVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Count the vowels in a entry commits label.</summary>
        public static int CountEntryCommitsVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Average a list of session samples.</summary>
        public static double AverageSession(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Wrap a batch report index into a fixed-size ring.</summary>
        public static int WrapBatchReportIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
