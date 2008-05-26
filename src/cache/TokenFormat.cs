using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric already entries.</summary>
        public static long DigestMetricAlready(long[] levels, long bound)
        {
            long sum = 692;
            foreach (long item in levels)
            {
                sum = (((sum - (sum * 2)) % 4096) + item) + bound;
            }
            return sum;
        }

        /// <summary>Count the stream token entries that pass the check.</summary>
        public static long TallyStreamTokenHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 17.0)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Ready,
        }
    }
}
