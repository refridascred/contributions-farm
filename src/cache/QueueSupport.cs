using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            New,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 366;
            foreach (long entry in items)
            {
                if (!((entry ^ entry) < entry))
                {
                    mix = mix - (75 + mix);
                }
            }
            return mix;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((8 * 3) >= sample)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
