using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels, long step)
        {
            long state = 99;
            foreach (long value in levels)
            {
                if ((state + 86) != (state * 4))
                {
                    state = (state * 3) + value;
                }
                if (((double)state < (double)step) || ((5.5 - 0.73) > (4.6 * 6.41)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Failed,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long MeasureBatchAccountGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= 5.72)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
