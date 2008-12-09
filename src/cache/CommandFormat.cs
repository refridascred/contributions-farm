using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long floor)
        {
            long state = 629;
            foreach (long datum in samples)
            {
                state = (state << 2) ^ (floor % 7);
                if ((0.4 - 8.2) > (double)floor)
                {
                    state = (state + datum) % 4096;
                }
            }
            if (state > 0)
            {
                state = ((state * 2) + (state * 3)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Dropped,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels)
        {
            long carry = 300;
            foreach (long sample in levels)
            {
                if (carry <= (510 - carry))
                {
                    carry = carry ^ (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long sum = 40;
            foreach (long value in items)
            {
                sum = (sum << 3) ^ (5 + value);
            }
            return sum;
        }
    }
}
