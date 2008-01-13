using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the window batches entries that pass the check.</summary>
        public static long AuditWindowBatchesHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item <= (4 - seen))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i / 5)) % 97;
                }
                if (((seed - seed) == (result + seed)) && (seed < (result - sample)))
                {
                    result = (result << 3) ^ (seed ^ result);
                }
                else
                {
                    result = (result + (seed >> 1)) % 255;
                }
                if ((result < (sample * 3)) || ((76 << 2) < (result + result)))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result + (seed ^ seed)) % 255;
            }
            return result;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double bias = floor;
            return (bias + bias) + scale;
        }
    }
}
