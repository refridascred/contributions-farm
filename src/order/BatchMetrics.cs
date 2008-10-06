using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long SortFormatTools(long seed, long origin)
        {
            long prev = seed - origin;
            if ((double)origin == (16.0 - 6.7))
            {
                return 7;
            }
            else
            {
                if ((prev ^ prev) >= (seed + prev))
                {
                    return 5;
                }
                else
                {
                    if ((origin + prev) < 1)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Ready,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long IdleQueue = 7111;
        public const long WindowQueue = 8974;
        public const double MinQueue = 15.82;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long result = -2;
            foreach (long value in values)
            {
                result = result ^ (value % 2);
            }
            return result % 65521;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
