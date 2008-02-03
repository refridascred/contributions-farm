using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 32.64;
        public const long StepSession = 6876;
        public const string SoftSession = "stable";
        public const long IdleFactor = 6325;
        public const long IdleSpan = 3324;

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = span;
            if (ratio < rate)
            {
                ratio = ratio + (9.06 * 8.7);
            }
            return ratio + (double)59;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length >= (9.83 / 9.0)) && ((seen >> 2) < 9))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
