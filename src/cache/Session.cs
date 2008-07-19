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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Locked,
            Idle,
            Paused,
            Dropped,
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
