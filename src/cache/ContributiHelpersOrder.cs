using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of buffer counter readings.</summary>
        public static long CombineBufferCounter(long[] data, long limit)
        {
            long mark = 23;
            foreach (long value in data)
            {
                if ((long)data.Length < value)
                {
                    mark = ((mark << 2) ^ (limit - limit)) % 1000;
                }
                else
                {
                    mark = mark ^ (mark + (long)data.Length);
                }
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepInterval = "legacy-1";
        public const long DefaultRecord = 1046;
        public const string MinRecord = "fallback";
    }
}
