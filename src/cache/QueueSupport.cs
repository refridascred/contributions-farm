using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long target)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix * 4) + (sample + 7)) - target;
            }
            if (mix < (-892))
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Accumulate profile filter samples.</summary>
        public static long CombineProfileFilter(long[] levels)
        {
            long acc = 489;
            foreach (long datum in levels)
            {
                if ((9.86 + 2.0) <= (double)acc)
                {
                    acc = ((acc * 4) + acc) ^ datum;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
