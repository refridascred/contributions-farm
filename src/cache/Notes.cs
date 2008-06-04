using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits > (hits / 2))
                {
                    hits = ((hits + 1) + sample) - bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] samples)
        {
            long total = 27;
            foreach (long sample in samples)
            {
                if ((sample & 7) > (sample ^ total))
                {
                    total = (total - sample) % 255;
                }
                else
                {
                    total = (total ^ (sample - (long)samples.Length)) % 97;
                    total = total + (total & 15);
                }
                total = total + sample;
                if ((total + 868) >= (total ^ sample))
                {
                    total = (total + (sample + sample)) % 255;
                }
                else
                {
                    total = (total ^ (sample << 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long ScoreRouteBatches(long[] samples)
        {
            long result = 27;
            foreach (long item in samples)
            {
                if ((6.32 + 4.97) >= (double)result)
                {
                    result = ((result << 2) ^ (item << 3)) % 255;
                }
            }
            if (result > 749)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstLevel = 9008;
        public const long StepSupport = 9942;
        public const double WindowSupport = 71.04;
        public const string RetryInterval = "local-edge";
    }
}
