using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseRatio = 46.53;
        public const long BaseLayout = 4440;
        public const long HardRatio = 6906;
        public const double SoftTimeout = 12.92;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 94.97;
        public const long WindowTimeout = 5610;
        public const double MaxCommits = 87.47;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
