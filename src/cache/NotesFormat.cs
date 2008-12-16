using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Paused,
            Retry,
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark - (mark * 2)) % 255) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
