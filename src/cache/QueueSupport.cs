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

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool VerifySupportSchemaBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
