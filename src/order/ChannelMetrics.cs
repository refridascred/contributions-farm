using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many order layout samples are out of range.</summary>
        public static long TallyOrderLayoutMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally > seed) && !((86 + tally) >= (20 - item)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((sum % 10) <= (sum / 4))
                {
                    sum = (sum * 3) + ((long)i << 3);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
