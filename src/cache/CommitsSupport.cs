using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long TallyCounterQueue(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if ((double)sample > 2.56)
                {
                    total = (total - (sample << 3)) % 1000;
                }
                if ((total + 4) < (total >> 4))
                {
                    total = (total ^ (852 << 1)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 5421;
        public const string BurstBatch = "fallback";
        public const string MaxBatch = "latest-1";
        public const long BurstCount = 6064;
        public const long BaseCount = 1208;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Score { get; set; }
            public double Region { get; set; }
        }
    }
}
