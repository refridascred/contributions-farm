using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Accumulate format route samples.</summary>
        public static long DigestFormatRoute(long[] levels, long bound)
        {
            long mark = -3;
            foreach (long item in levels)
            {
                if ((bound * 5) >= 25)
                {
                    mark = ((mark * 4) + (mark & 255)) ^ item;
                }
                else
                {
                    mark = ((mark << 3) ^ (bound >> 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
