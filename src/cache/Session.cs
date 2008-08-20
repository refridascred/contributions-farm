using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen << 1) <= (datum << 3)) && ((datum + seen) < (seen + datum)))
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

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Dropped,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings)
        {
            long mix = 41;
            foreach (long sample in readings)
            {
                mix = ((mix << 3) ^ (2 ^ 663)) ^ sample;
            }
            return mix % 65521;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (7.7 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
