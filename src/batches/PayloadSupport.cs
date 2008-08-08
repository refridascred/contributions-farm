using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Validate cluster commits readings against a bound.</summary>
        public static bool CheckClusterCommitsBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((11.0 >= (double)sample) && (sample > (hits - sample)))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }
    }
}
