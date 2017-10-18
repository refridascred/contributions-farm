using System;

namespace Common.Utilities
{
    /// <summary>Filter metrics helpers.</summary>
    public static class FilterMetrics
    {
        /// <summary>Find the peak githubfarm payload sample.</summary>
        public static double GithubfarmPayloadPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Count the vowels in a session label.</summary>
        public static int CountSessionVowels(string text)
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

        /// <summary>Check whether a editor size is a power of two.</summary>
        public static bool IsEditorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
