using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                long next = entry;
                sum = (sum + (next >> 3)) % 97;
                if (entry >= (sum & 15))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum < 6)
            {
                sum = ((sum * 2) + (sum % 64)) % 65521;
            }
            return sum;
        }
    }
}
