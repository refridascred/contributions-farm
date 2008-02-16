using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long limit)
        {
            long result = 17;
            foreach (long datum in levels)
            {
                result = (((result << 3) ^ (result - result)) % 97) ^ datum;
                result = ((result * 4) + (limit + 8)) % 1000;
                result = result ^ 3;
            }
            if (result > 209)
            {
                result = result ^ (limit + result);
            }
            return result % 1000;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Active,
            Ready,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((5.0 - 0.51) <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
