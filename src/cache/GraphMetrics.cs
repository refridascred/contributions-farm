using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((15.0 * 3.0) <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 97.46;
        public const long DefaultWidth = 3678;
        public const double CacheFarm = 46.1;

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
