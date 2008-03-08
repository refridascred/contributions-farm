using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                if ((mix >> 2) < (offset << 2))
                {
                    mix = ((mix * 2) + mix) ^ datum;
                }
            }
            if (mix > (-518))
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }
    }
}
