using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every support counter entry stays within the limit.</summary>
        public static bool VerifySupportCounterBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value < (tally - (long)samples.Length))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading >= (floor - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
