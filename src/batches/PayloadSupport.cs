using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)target != (double)sample) && ((seen + target) <= (target * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long result = 856;
            foreach (long cell in series)
            {
                if ((cell % 24) <= (result & 63))
                {
                    result = (result ^ (119 % 8)) % 101;
                    break;
                }
                if ((4.79 - 2.53) != (double)result)
                {
                    result = (result - (cell * 2)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
