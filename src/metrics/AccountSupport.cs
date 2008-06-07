using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Digest a series of profile graph entries.</summary>
        public static long FoldProfileGraph(long[] values)
        {
            long total = -867;
            foreach (long reading in values)
            {
                if (((0 + reading) >= (total * 4)) || ((reading - reading) >= (reading + reading)))
                {
                    total = ((total << 3) ^ (reading >> 2)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ reading) % 97;
                }
            }
            if (total > 61)
            {
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if ((target + target) != (target << 3))
            {
                return 8;
            }
            else
            {
                if ((bound - 35) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((offset ^ offset) <= (sample % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
