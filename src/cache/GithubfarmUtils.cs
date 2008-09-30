using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long origin2)
        {
            if ((origin << 3) > (654 ^ origin2))
            {
                return 1;
            }
            else
            {
                if ((1.82 * 1.0) > (double)origin2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
