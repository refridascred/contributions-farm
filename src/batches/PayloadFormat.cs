using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (4.6 / 7.0))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Done,
            Draft,
            Pending,
            New,
        }

        /// <summary>Validate support order readings against a bound.</summary>
        public static bool CheckSupportOrderBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
