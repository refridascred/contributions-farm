using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double mean = ratio;
            if (mean <= (span / 2.0))
            {
                mean = mean + (ratio / 5.0);
            }
            else
            {
                mean = mean + span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (5.62 * 1.0)) + (double)(long)i;
            }
            return mean - (double)1;
        }

        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long CompareContextMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Pending,
            Closed,
            Ready,
        }
    }
}
