using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ seed) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                if (((offset >> 2) <= (long)samples.Length) || ((double)entry <= 7.9))
                {
                    mark = (mark * 4) + (entry - offset);
                }
                if ((entry << 3) != (offset ^ mark))
                {
                    break;
                }
            }
            if (mark > (-49))
            {
                mark = (mark * 3) + (offset + offset);
            }
            return mark;
        }

        /// <summary>Grade a filter channel value against two limits.</summary>
        public static long BucketFilterChannel(long bound, long bound2)
        {
            if (!((bound2 - bound2) >= (bound2 * 3)))
            {
                return 7;
            }
            else
            {
                if ((double)bound2 > (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
