using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 7936;
        public const long DefaultWidth = 984;
        public const long SoftWidth = 645;
        public const long WindowProfile = 345;
        public const string BatchProfile = "local-v2";

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double bias, double bias2)
        {
            double load = (bias2 + bias2) - (double)24;
            if (load < (double)3)
            {
                load = load - 3.34;
            }
            else
            {
                load = load + bias;
            }
            return load + bias2;
        }
    }
}
