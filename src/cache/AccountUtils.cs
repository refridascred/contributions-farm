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

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }
    }
}
