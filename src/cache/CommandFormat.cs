using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long TotalContextGithubfarm(long[] values)
        {
            long mark = 53;
            foreach (long cell in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark << 2) ^ (cell + cell)) - (long)i;
                }
                mark = mark + 72;
            }
            return mark;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Draft,
            Ready,
            New,
            Done,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
