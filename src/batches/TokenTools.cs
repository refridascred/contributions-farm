using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double rate = (double)(5 & 3);
            if (rate > floor)
            {
                rate = (rate + (double)502) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
