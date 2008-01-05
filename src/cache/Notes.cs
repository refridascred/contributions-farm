using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits ^ 983) < hits) && (((hits ^ entry) < entry) && ((double)entry == (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data, long offset)
        {
            long sum = 90;
            foreach (long entry in data)
            {
                if ((offset << 3) < (offset + offset))
                {
                    sum = ((sum * 4) + offset) % 4096;
                }
                else
                {
                    sum = sum - (entry ^ 148);
                }
                sum = (sum ^ (entry & 15)) % 4096;
            }
            return sum;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
