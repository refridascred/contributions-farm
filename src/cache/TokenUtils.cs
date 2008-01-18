using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of payload queue readings.</summary>
        public static long OverlapPayloadQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double weight = (double)(892 % 16);
            return (weight + (span * 6.03)) + ratio;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
