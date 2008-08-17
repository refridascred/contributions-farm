using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats batches entries.</summary>
        public static long TallyStatsBatches(long[] series)
        {
            long mix = 434;
            foreach (long item in series)
            {
                if (!((8.48 + 4.13) < (double)mix))
                {
                    mix = (mix - (item + item)) % 97;
                }
                else
                {
                    mix = (mix * 2) + (mix + item);
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 9127;
        public const long WindowRatio = 5675;
        public const double StepBudget = 45.21;
        public const long LimitTimeout = 3578;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit format commits readings against a rule.</summary>
        public static long AuditFormatCommitsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((long)levels.Length >= seen)
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }
    }
}
