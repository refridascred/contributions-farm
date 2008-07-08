using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
