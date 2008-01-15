using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            New,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double ratio = (rate * 19.0) + 2.42;
            if (ratio > (bias * 8.4))
            {
                ratio = ratio - (ratio - rate);
            }
            return ratio + rate;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            Dropped,
            Paused,
            Stale,
            Retry,
        }
    }
}
