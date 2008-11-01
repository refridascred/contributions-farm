using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit format record readings against a rule.</summary>
        public static long AuditFormatRecordOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (seed > (value + value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 2) <= (count % 97)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
