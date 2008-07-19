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

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long acc = 8;
            foreach (long entry in series)
            {
                if ((99 + entry) != (entry + origin))
                {
                    acc = ((acc << 2) ^ (origin - origin)) % 97;
                }
                else
                {
                    acc = (acc - (acc << 1)) % 97;
                }
                if ((5.6 + 0.77) >= (double)entry)
                {
                    break;
                }
            }
            return acc % 65521;
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
