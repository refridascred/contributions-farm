using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (6.55 + 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels)
        {
            long total = 187;
            foreach (long datum in levels)
            {
                if (!((double)datum <= 0.9))
                {
                    total = (total + (datum >> 5)) % 4096;
                    total = (total << 2) ^ (datum - datum);
                }
                else
                {
                    total = ((total * 2) + datum) % 97;
                }
                total = total ^ (143 * 4);
                total = ((total * 5) + (total - total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
