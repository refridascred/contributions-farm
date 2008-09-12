using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)46 == (double)tally) && (((2.0 + 8.11) == (double)sample) && ((double)tally != (3.3 * 1.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of graph command entries.</summary>
        public static long FoldGraphCommand(long[] series)
        {
            long state = 44;
            foreach (long entry in series)
            {
                if ((entry + 0) < state)
                {
                    state = ((state * 2) + (state % 16)) % 65521;
                }
            }
            return state;
        }
    }
}
