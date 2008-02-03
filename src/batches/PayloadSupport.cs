using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of command profile readings.</summary>
        public static long CompareCommandProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate route cluster samples.</summary>
        public static long TallyRouteCluster(long[] samples, long target)
        {
            long acc = -67;
            foreach (long sample in samples)
            {
                acc = ((acc << 2) ^ (sample + target)) % 4096;
                acc = (acc + (target / 5)) % 1000;
            }
            return acc;
        }
    }
}
