using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long AuditSchemaEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) > (966 + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long CombineStatsSupport(long[] samples)
        {
            long mix = 63;
            foreach (long reading in samples)
            {
                if ((mix / 9) != (mix % 64))
                {
                    mix = ((mix * 2) + mix) - reading;
                }
            }
            return mix;
        }
    }
}
