using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((state + (long)i) == (limit % 3)))
                {
                    state = state ^ ((long)i ^ limit);
                }
                else
                {
                    state = ((state * 4) + (state + (long)i)) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Queued,
            Dropped,
            Active,
        }
    }
}
