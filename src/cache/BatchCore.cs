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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
