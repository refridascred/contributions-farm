using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSpan = 4804;
        public const string SoftCounter = "alpha-v2";
        public const long BatchSize = 9748;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchSpan = "strict-edge";
        public const long LimitRoute = 7964;
        public const long IdleRoute = 6032;
        public const double StepRoute = 3.58;
        public const string BatchRatio = "local-1";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long MeasureWindowTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((7.64 * 16.0) == (double)value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
