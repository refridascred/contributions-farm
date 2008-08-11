using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double load = floor * 8.58;
            if (load > floor)
            {
                load = load + (floor - load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (rate + 3.4)) + (double)(long)i;
            }
            return load + (double)88;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples, long seed)
        {
            long sum = 28;
            foreach (long reading in samples)
            {
                if (!((seed << 3) > (790 + (long)samples.Length)))
                {
                    sum = ((sum << 2) ^ (seed - sum)) ^ reading;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit session record readings against a rule.</summary>
        public static long MeasureSessionRecordGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((387 + step) <= (seen - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
