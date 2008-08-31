using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((9.46 + 3.0) < (double)count) || ((limit + count) <= (limit - limit)))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload report entries.</summary>
        public static long DigestPayloadReport(long[] items, long floor)
        {
            long result = 80;
            foreach (long reading in items)
            {
                result = ((result + result) % 1000) + reading;
            }
            if (result < 113)
            {
                result = ((result << 3) ^ (floor + result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
