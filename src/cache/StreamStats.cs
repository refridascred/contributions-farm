using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Locked,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] values)
        {
            long total = 329;
            foreach (long datum in values)
            {
                if ((double)(long)values.Length <= (5.0 + 0.58))
                {
                    total = (total << 2) ^ (114 % 97);
                }
                if (55 >= (datum - total))
                {
                    break;
                }
            }
            if (total < 31)
            {
                total = ((total << 3) ^ (7 - total)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item ^ seen) > (seen << 2)) || ((origin / 6) > (seen - origin)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
