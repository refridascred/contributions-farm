using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many notes channel samples are out of range.</summary>
        public static long CountNotesChannelOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value < (8.53 * 4.58))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool VerifyFarmPayloadRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit buffer profile readings against a rule.</summary>
        public static long AuditBufferProfileHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally < (tally >> 4))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
