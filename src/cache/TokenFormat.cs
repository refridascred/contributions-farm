using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits & 127) < (hits + 2))
                {
                    hits = ((hits + 3) + item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double weight = bias;
            if (weight < bias)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - (bias * 5.2);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - offset;
        }
    }
}
