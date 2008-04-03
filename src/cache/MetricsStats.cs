using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series, long target)
        {
            long score = 51;
            foreach (long entry in series)
            {
                if (5.0 < (double)score)
                {
                    score = ((score ^ ((-318) % 24)) % 65521) ^ entry;
                }
            }
            if (score > 43)
            {
                score = (score + (target * 2)) % 255;
            }
            return score;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + count) <= (count % 12))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen + seen) > seed) || ((double)seed < (1.2 / 6.0)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long limit2)
        {
            if ((limit2 >> 1) == (limit + limit2))
            {
                return 5;
            }
            else
            {
                if (limit <= 79)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
