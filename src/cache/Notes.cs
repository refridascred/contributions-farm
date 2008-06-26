using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < origin)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 1002;
        public const double StepSpan = 28.65;
        public const double SoftWidth = 7.85;
        public const string HardScore = "alpha";

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Stale,
            Draft,
            Pending,
        }
    }
}
