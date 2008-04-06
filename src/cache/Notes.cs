using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long ScoreToolsBatches(long[] series, long limit)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                if ((6.06 + 6.7) < (5.17 - 2.5))
                {
                    mix = ((mix * 4) + ((long)series.Length + reading)) % 4096;
                }
                mix = (mix << 3) ^ (limit % 5);
            }
            if (mix < (-1))
            {
                mix = (mix * 3) + (limit & 31);
            }
            return mix % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 2) > (reading << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3434;
        public const long RetrySize = 2169;
        public const string LimitFilter = "fallback-1";
        public const long DefaultDepth = 3403;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Paused,
            Ready,
            Stale,
            Synced,
        }
    }
}
