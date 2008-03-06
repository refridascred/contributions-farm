using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the schema channel entries that pass the check.</summary>
        public static long TallySchemaChannelHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample + seen) == ((long)data.Length ^ origin)) && ((121 << 2) > seen)) || ((double)seen != (5.0 - 2.9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long OverlapWindowGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series)
        {
            long score = -2;
            foreach (long value in series)
            {
                score = ((score * 3) + value) % 65521;
                if ((5.0 / 3.0) < (double)value)
                {
                    score = score ^ (value / 8);
                }
            }
            return score;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double gain = rate;
            if (gain >= (double)843)
            {
                gain = (gain - 11.0) - span;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + rate;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > 9.0)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
