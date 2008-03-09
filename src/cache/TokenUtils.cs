using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double mean = (double)(72 * 5);
            if (mean <= (9.8 - span))
            {
                mean = (mean - mean) - gain;
            }
            else
            {
                mean = mean - (span / 9.0);
            }
            return mean - (double)808;
        }

        /// <summary>Find the first counter already entry that matches the target.</summary>
        public static long LookupCounterAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
