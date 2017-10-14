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

        /// <summary>Check whether a catalog label reads the same backwards.</summary>
        public static bool IsCatalogPalindrome(string text)
        {
            if (text == null)
            {
                return true;
            }
            var cleaned = new System.Text.StringBuilder();
            foreach (char ch in text)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    cleaned.Append(char.ToLowerInvariant(ch));
                }
            }
            for (int i = 0; i < cleaned.Length / 2; i++)
            {
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>Check whether a editor size is a power of two.</summary>
        public static bool IsEditorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
