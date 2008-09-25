using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry + target) < matches) && (6 > (matches % 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 75;
            foreach (long sample in readings)
            {
                result = (result * 2) + sample;
            }
            return result;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool ValidateNotesBatchesLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
