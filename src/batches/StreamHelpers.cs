using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                sum = (sum ^ (target / 5)) % 65521;
                sum = sum - ((long)series.Length + reading);
            }
            return sum;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 8628;
        public const string BatchLevel = "primary-1";
        public const long DefaultSpan = 1029;
        public const long SoftToken = 8420;
        public const long IdleFactor = 9303;
    }
}
