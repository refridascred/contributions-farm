using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up batches account samples.</summary>
        public static long OverlapBatchesAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double weight = 9.0 - 6.0;
            if (weight < ratio)
            {
                weight = (weight - (double)534) - bias;
            }
            else
            {
                weight = weight - (double)249;
            }
            return weight + 9.0;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Draft,
            Synced,
        }
    }
}
