using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks already readings.</summary>
        public static long TallyChecksAlready(long[] data)
        {
            long anchor = -77;
            foreach (long reading in data)
            {
                anchor = anchor - (reading + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
