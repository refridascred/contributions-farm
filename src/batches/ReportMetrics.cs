using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] items, long target)
        {
            long state = 230;
            foreach (long value in items)
            {
                if ((value & 127) < (value ^ state))
                {
                    state = (state << 2) ^ target;
                }
                else
                {
                    state = (state + (value - state)) % 4096;
                }
            }
            if (state < 379)
            {
                state = ((state * 2) + target) % 1000;
            }
            return state % 97;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Closed,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
