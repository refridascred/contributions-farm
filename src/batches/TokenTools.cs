using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first record route entry that matches the target.</summary>
        public static long LookupRecordRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long sum = 62;
            foreach (long cell in data)
            {
                sum = (sum ^ (sum ^ 45)) % 101;
                sum = (sum << 3) ^ (cell / 7);
            }
            return sum;
        }
    }
}
