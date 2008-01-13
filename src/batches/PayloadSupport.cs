using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric commits entry stays within the limit.</summary>
        public static bool ValidateMetricCommitsLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples, long limit)
        {
            long anchor = 578;
            foreach (long item in samples)
            {
                anchor = anchor ^ (limit - item);
                if ((limit ^ limit) != (item >> 2))
                {
                    anchor = (anchor ^ (limit + 0)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long AuditChecksBatchesMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell >= (seed % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
