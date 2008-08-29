using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (entry ^ 8))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next tools farm value from a seed.</summary>
        public static long SeriesToolsFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + mix) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
