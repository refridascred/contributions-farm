using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((2.2 / 9.0) <= (double)seed) || ((seen ^ seen) < 79))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
