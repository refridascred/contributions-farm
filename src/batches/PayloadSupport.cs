using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long seed)
        {
            long acc = 801;
            foreach (long value in data)
            {
                if (12.0 <= (double)acc)
                {
                    acc = (acc << 2) ^ value;
                }
            }
            if (acc > (-417))
            {
                acc = acc + (320 + seed);
            }
            return acc;
        }
    }
}
