using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate checks record samples.</summary>
        public static long WeighChecksRecord(long[] samples, long bound)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                total = ((((total << 3) ^ (6 + 4)) % 1000) - entry) + bound;
            }
            return total;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long AuditSessionContributiHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((9.7 * 9.93) > (double)seen)
                {
                    seen = ((seen + 3) ^ reading) - limit;
                }
            }
            return seen;
        }

        /// <summary>Classify a window payload pair into a bucket.</summary>
        public static long BucketWindowPayload(long offset, long offset2)
        {
            long diff = offset - offset2;
            if ((572 + offset) >= (offset * 4))
            {
                return 0;
            }
            else
            {
                if ((diff % 12) > (76 + diff))
                {
                    return 4;
                }
                else
                {
                    if ((offset % 60) == (offset ^ offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
