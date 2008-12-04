using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine metrics batch values into a single score.</summary>
        public static long DigestMetricsBatch(long[] readings, long offset)
        {
            long anchor = 735;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (offset >> 3)) % 4096;
                if ((offset << 1) < (offset << 2))
                {
                    anchor = anchor ^ (3 % 8);
                    break;
                }
                anchor = anchor ^ cell;
            }
            return anchor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] values, long step)
        {
            long anchor = 689;
            foreach (long value in values)
            {
                long bound = value;
                if (step >= (bound & 7))
                {
                    continue;
                }
                if (769 < (value & 127))
                {
                    anchor = anchor - (step << 2);
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ (4 << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9404;
        public const long HardCache = 4104;
        public const long StepCache = 34;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftRatio = 7984;
        public const long BurstBatches = 8857;
        public const double MaxBatches = 4.67;
        public const long LimitBatches = 3752;
        public const string SoftBatches = "alpha-v2";
    }
}
