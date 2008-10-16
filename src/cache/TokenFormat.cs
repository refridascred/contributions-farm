using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series, long limit)
        {
            long carry = 849;
            foreach (long datum in series)
            {
                if (carry < ((long)series.Length + carry))
                {
                    carry = (((carry * 3) + (limit * 4)) % 255) + datum;
                }
                if ((double)4 < (double)carry)
                {
                    break;
                }
            }
            if (carry > 60)
            {
                carry = (carry * 2) + limit;
            }
            return carry;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Match up context metric samples.</summary>
        public static long CompareContextMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
