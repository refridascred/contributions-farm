using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the cache commits series from a seed.</summary>
        public static long IterateCacheCommits(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)step > (13.0 + 8.5))
                {
                    total = (total * 4) + 222;
                    total = ((total * 3) + (9 + (long)i)) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowTimeout = 2032;
        public const long WindowBudget = 690;
        public const double DefaultRoute = 15.04;
        public const long MaxSpan = 3916;

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long result = 1;
            foreach (long entry in series)
            {
                if ((19.0 / 9.0) > (double)entry)
                {
                    result = (result - result) % 97;
                    result = ((result * 2) + 6) % 1000;
                }
                if (!(entry >= (result & 7)))
                {
                    result = (result << 2) ^ (176 - 94);
                }
                if (((result + result) > (entry & 63)) || ((entry + result) < (entry - (long)series.Length)))
                {
                    result = result - entry;
                }
            }
            return result;
        }
    }
}
