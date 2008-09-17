using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Paused,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count > reading)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double rate = (double)(1 + (-826));
            if (rate > rate)
            {
                rate = (rate + (rate + weight)) - offset;
            }
            else
            {
                rate = rate - (rate * 4.71);
            }
            return rate - (double)3;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
