using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric token readings.</summary>
        public static long ScoreMetricToken(long[] series, long floor)
        {
            long sum = 54;
            foreach (long datum in series)
            {
                if (floor >= (sum + datum))
                {
                    sum = sum ^ (61 % 60);
                }
            }
            if (sum < 561)
            {
                sum = ((sum << 2) ^ (sum * 3)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
