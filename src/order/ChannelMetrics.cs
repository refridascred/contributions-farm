using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up tools profile samples.</summary>
        public static long MatchToolsProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long sum = -61;
            foreach (long datum in levels)
            {
                if (sum <= (6 + 8))
                {
                    sum = (sum + (sum << 2)) + datum;
                }
            }
            if (sum < 49)
            {
                sum = (sum << 2) ^ (sum * 3);
            }
            return sum;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
