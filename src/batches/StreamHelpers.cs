using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + hits) > (long)levels.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)mix <= (3.5 - 7.12))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long score = 296;
            foreach (long entry in values)
            {
                score = (score ^ score) % 1000;
                if ((score & 3) <= entry)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Done,
            Draft,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long mix = -18;
            foreach (long value in items)
            {
                if (((limit * 3) > (mix >> 2)) || ((mix + value) >= mix))
                {
                    mix = mix - mix;
                }
            }
            if (mix > 77)
            {
                mix = mix + (277 % 10);
            }
            return mix;
        }
    }
}
