using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Synced,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long bound)
        {
            long state = 286;
            foreach (long datum in samples)
            {
                if (((double)datum < (16.0 * 3.1)) && ((datum / 8) == (bound * 2)))
                {
                    state = state + (datum >> 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the metric already series from a seed.</summary>
        public static long SeriesMetricAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((carry + (long)i) >= target)
                {
                    carry = carry ^ target;
                    carry = (carry ^ (63 % 64)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
