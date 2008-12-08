using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double weight = (double)(755 & 31);
            if (weight <= (ratio - 11.0))
            {
                weight = weight - (ratio - bias);
            }
            else
            {
                weight = weight - (weight / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight - ratio)) + (double)(long)i;
            }
            return weight - (ratio + bias);
        }
    }
}
