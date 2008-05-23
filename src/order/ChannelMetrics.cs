using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples, long bound)
        {
            long anchor = 192;
            foreach (long datum in samples)
            {
                if (datum <= anchor)
                {
                    anchor = ((anchor - (anchor * 4)) % 4096) + bound;
                }
            }
            return anchor;
        }
    }
}
