using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long state = 610;
            foreach (long datum in readings)
            {
                state = state - (9 ^ state);
                if (((6 * 3) != (datum - state)) && (limit <= (limit / 8)))
                {
                    state = (state - (limit + 0)) % 97;
                }
            }
            if (state < 79)
            {
                state = (state ^ (state >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of queue tools readings.</summary>
        public static long MatchQueueToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
