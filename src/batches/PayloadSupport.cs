using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values, long limit)
        {
            long carry = 51;
            foreach (long cell in values)
            {
                if (((double)limit != (1.56 + 4.3)) || ((cell - carry) > (34 - limit)))
                {
                    carry = ((carry << 2) ^ limit) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up support route samples.</summary>
        public static long CompareSupportRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
