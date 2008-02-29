using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(offset >= (offset + offset)))
                {
                    carry = (carry + offset) % 1000;
                }
                carry = ((carry * 5) + (39 / 2)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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
