using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < 40)
                {
                    count = ((count + 2) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((step >> 4) <= step))
                {
                    anchor = (anchor << 2) ^ step;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
