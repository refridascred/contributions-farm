using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                if (((cell << 1) < (anchor ^ cell)) && ((anchor / 5) >= anchor))
                {
                    anchor = ((anchor * 5) + 7) % 97;
                }
                if (!((anchor ^ anchor) == (9 + anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
