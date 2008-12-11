using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = (carry - (374 * 4)) ^ datum;
            }
            if (carry < 2)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] values)
        {
            long anchor = 818;
            foreach (long item in values)
            {
                anchor = (anchor - item) % 97;
                anchor = (anchor << 3) ^ ((long)values.Length - anchor);
            }
            return anchor;
        }
    }
}
