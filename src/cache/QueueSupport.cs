using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) != (seen + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
