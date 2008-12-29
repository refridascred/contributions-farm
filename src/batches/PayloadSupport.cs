using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long score = 58;
            foreach (long datum in values)
            {
                score = ((score * 5) + datum) % 255;
                if ((1.18 < (11.0 + 6.6)) || ((score ^ limit) > datum))
                {
                    score = (score ^ score) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Closed,
            Stale,
        }
    }
}
