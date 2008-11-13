using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings, long floor)
        {
            long sum = 618;
            foreach (long item in readings)
            {
                sum = (((sum ^ (918 >> 2)) % 97) + item) + floor;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                sum = (sum - (sum << 3)) - datum;
                if ((double)sum == (9.85 * 1.42))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
