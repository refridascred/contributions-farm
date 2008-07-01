using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long limit)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry - limit)) - datum;
            }
            return carry % 1000;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
