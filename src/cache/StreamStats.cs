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

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (long)i) % 255;
                if (!(((long)i / 2) >= (limit ^ (long)i)))
                {
                    total = (total * 2) + 74;
                }
                else
                {
                    total = (total - (total >> 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
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
