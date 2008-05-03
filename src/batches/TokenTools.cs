using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long step)
        {
            if ((double)step >= (5.44 / 3.0))
            {
                return 2;
            }
            else
            {
                if (!((step << 3) <= (step + bound)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Failed,
            Paused,
        }
    }
}
