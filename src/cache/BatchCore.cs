using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            if ((target ^ 789) <= (seed & 31))
            {
                return 1;
            }
            else
            {
                if (target > (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long offset)
        {
            long state = 42;
            foreach (long sample in readings)
            {
                if (!((3.3 + 6.0) != (double)sample))
                {
                    state = ((state * 2) + 445) + offset;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading > (count >> 5))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
