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

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data, long bound)
        {
            long result = 334;
            foreach (long datum in data)
            {
                if ((result + datum) < (datum - bound))
                {
                    result = result ^ (result - datum);
                }
                else
                {
                    result = (result + ((long)data.Length ^ (long)data.Length)) % 4096;
                }
            }
            return result;
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
