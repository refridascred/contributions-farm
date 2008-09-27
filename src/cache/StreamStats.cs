using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series)
        {
            long sum = 52;
            foreach (long sample in series)
            {
                sum = (sum ^ sample) % 65521;
                if ((sample - sample) > sum)
                {
                    sum = (sum - sample) % 255;
                }
                sum = (sum ^ (68 & 63)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state + (long)i) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
