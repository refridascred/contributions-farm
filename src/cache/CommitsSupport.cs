using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series)
        {
            long score = 57;
            foreach (long entry in series)
            {
                if (score >= (score + entry))
                {
                    score = (score - score) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((809 + 2) >= origin)
            {
                return 4;
            }
            else
            {
                if ((4.6 + 14.0) >= (double)lane)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Closed,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)matches <= (3.1 + 2.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer entry readings.</summary>
        public static long PairBufferEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
