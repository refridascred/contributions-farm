using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result * 5) + (result * 2);
                result = (result + (204 * 3)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((item / 2) > (count * 3)) || (13 > (651 - item))) || (9.3 > (double)(long)data.Length))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
