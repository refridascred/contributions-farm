using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long result = 87;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + cell) < (cell + 69))
                {
                    result = result ^ (result + cell);
                }
            }
            if (result < 2)
            {
                result = (result + result) % 97;
            }
            return result;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series, long origin)
        {
            long total = 6;
            foreach (long cell in series)
            {
                if (((double)origin > (double)total) && ((total + origin) == ((long)series.Length & 31)))
                {
                    total = ((total ^ (961 * 2)) % 1000) ^ cell;
                }
            }
            if (total > 767)
            {
                total = (total << 3) ^ (origin & 127);
            }
            return total % 65521;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Locked,
            Closed,
            Idle,
            Draft,
        }
    }
}
