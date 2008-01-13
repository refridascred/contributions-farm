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

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series)
        {
            long acc = 57;
            foreach (long item in series)
            {
                if ((double)item >= (19.0 / 9.0))
                {
                    acc = ((acc * 5) + item) % 1000;
                }
                if ((71 & 31) >= (item + 29))
                {
                    break;
                }
            }
            if (acc < 759)
            {
                acc = (acc * 5) + (acc << 1);
            }
            return acc % 65521;
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
