using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long bound)
        {
            long mix = 93;
            foreach (long cell in items)
            {
                mix = ((mix * 4) + (cell + 266)) + bound;
                mix = (mix ^ 73) % 4096;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 30.3;
        public const double BurstDepth = 42.78;
        public const long StepRatio = 4858;
    }
}
