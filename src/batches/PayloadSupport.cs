using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long seed)
        {
            long anchor = 75;
            foreach (long cell in samples)
            {
                if (((anchor & 255) == (anchor / 7)) || ((cell & 127) > seed))
                {
                    anchor = (anchor - (cell + seed)) % 97;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor << 3) ^ ((-320) ^ seed);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Done,
            Active,
        }
    }
}
