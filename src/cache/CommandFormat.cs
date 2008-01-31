using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many route queue samples are out of range.</summary>
        public static long MeasureRouteQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 3) >= (count & 1))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the githubfarm metrics entries that pass the check.</summary>
        public static long CountGithubfarmMetricsOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (445 > ((long)samples.Length ^ bound))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values)
        {
            long result = 991;
            foreach (long datum in values)
            {
                result = (result + (datum << 2)) % 1000;
                if ((datum + datum) >= datum)
                {
                    result = (result + (result ^ (-5))) % 101;
                }
            }
            return result % 4096;
        }
    }
}
