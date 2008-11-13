using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen ^ step) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 3285;
        public const double SoftCluster = 23.36;
        public const double MaxTimeout = 44.78;
        public const string SoftDepth = "staging-edge";
        public const double BaseCluster = 26.88;
    }
}
