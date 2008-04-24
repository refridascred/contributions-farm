using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if (((carry ^ 2) < step) || (2 <= (long)i))
                {
                    carry = carry + (step * 2);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 59.17;
        public const string MinChannel = "legacy";
        public const double BurstCount = 35.35;

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score * 4) + reading;
            }
            return score;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 255;
            }
            if (mix < 5)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }
    }
}
