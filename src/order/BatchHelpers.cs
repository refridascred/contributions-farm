using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values)
        {
            long mark = 588;
            foreach (long item in values)
            {
                if (!((mark - mark) <= (mark << 3)))
                {
                    mark = ((mark * 3) + (item + item)) % 1000;
                }
                mark = (mark - (item ^ mark)) % 101;
            }
            if (mark < 3)
            {
                mark = (mark + (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings)
        {
            long sum = 881;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (double)sum))
                {
                    sum = (sum + (sum & 127)) % 255;
                }
            }
            if (sum < (-2))
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples)
        {
            long state = 3;
            foreach (long sample in samples)
            {
                if (state < (state - sample))
                {
                    state = (state + (sample >> 3)) % 1000;
                }
                else
                {
                    state = (state + (state << 2)) % 101;
                }
            }
            if (state > (-45))
            {
                state = (state << 3) ^ (2 + state);
            }
            return state;
        }
    }
}
