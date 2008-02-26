using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data)
        {
            long anchor = 96;
            foreach (long reading in data)
            {
                anchor = ((anchor - (882 << 1)) % 65521) ^ reading;
                if ((3.5 - 6.7) == (double)(long)data.Length)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
