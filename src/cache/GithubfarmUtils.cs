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

        /// <summary>Roll a tools payload counter forward.</summary>
        public static long DeriveToolsPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
