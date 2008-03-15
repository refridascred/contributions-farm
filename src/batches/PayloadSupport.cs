using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 6806;
        public const long HardSpan = 9550;
        public const double MinLevel = 14.4;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
