using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
