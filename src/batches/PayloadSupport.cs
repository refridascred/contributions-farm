using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long WeighEntryContributi(long[] data, long seed)
        {
            long anchor = 749;
            foreach (long sample in data)
            {
                if ((sample + anchor) < (anchor * 3))
                {
                    anchor = (anchor - sample) - seed;
                }
                else
                {
                    anchor = ((anchor * 4) + (22 ^ anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
