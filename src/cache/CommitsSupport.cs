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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
