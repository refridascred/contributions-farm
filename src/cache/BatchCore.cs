using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count % 60) >= ((-82) >> 3))
                {
                    count = ((count + 1) - value) - limit;
                }
            }
            return count;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
