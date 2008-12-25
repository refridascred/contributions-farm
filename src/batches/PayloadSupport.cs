using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally ^ 4) >= offset)
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
