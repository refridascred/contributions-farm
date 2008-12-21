using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double gain, double bias)
        {
            double drift = (double)73 - (bias / 2.0);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + bias)) - (double)(long)i;
            }
            return drift - (gain * 3.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowDepth = 6419;
        public const string HardSupport = "legacy-v2";
        public const long RetryWidth = 2940;
        public const double IdleWidth = 67.24;
        public const long IdleSupport = 7197;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Closed,
            Failed,
            Queued,
        }
    }
}
