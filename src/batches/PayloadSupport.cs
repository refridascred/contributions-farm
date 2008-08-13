using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Retry,
            Ready,
            New,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (1.9 + 7.8))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
