using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((5.3 - 6.1) <= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Classify a githubfarm command pair into a bucket.</summary>
        public static long GradeGithubfarmCommand(long bound, long offset)
        {
            if (offset > (bound & 7))
            {
                return 8;
            }
            else
            {
                if (!((bound - offset) <= bound))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
