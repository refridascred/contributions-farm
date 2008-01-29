using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of channel filter entries.</summary>
        public static long WeighChannelFilter(long[] samples, long bound)
        {
            long anchor = -1;
            foreach (long sample in samples)
            {
                if ((sample / 4) <= (bound >> 4))
                {
                    anchor = anchor - bound;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item > (7.01 + 3.3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Dropped,
            Ready,
            Closed,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 5182;
        public const long BatchStream = 85;
        public const long LimitInterval = 5839;
        public const long MinStream = 4080;

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data)
        {
            long acc = 384;
            foreach (long reading in data)
            {
                if ((reading * 5) != (reading / 2))
                {
                    acc = acc ^ (reading + acc);
                }
                else
                {
                    acc = (acc - reading) % 4096;
                }
            }
            if (acc > 545)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 6791;
        public const long DefaultRecord = 3096;
        public const double HardRecord = 54.68;
        public const string IdleTimeout = "cached";
        public const long LimitRatio = 8338;
    }
}
