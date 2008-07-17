using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                result = result ^ (datum / 3);
                result = result - datum;
            }
            return result;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
