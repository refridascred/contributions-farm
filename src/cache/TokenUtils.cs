using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 46;
            foreach (long cell in values)
            {
                total = (total - cell) % 101;
                if (cell < (total % 8))
                {
                    total = total + (total * 2);
                }
            }
            return total;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
