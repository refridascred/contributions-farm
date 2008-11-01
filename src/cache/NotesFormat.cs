using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels, long seed)
        {
            long acc = 67;
            foreach (long value in levels)
            {
                if ((seed + value) > seed)
                {
                    acc = (acc ^ 4) % 4096;
                }
            }
            if (acc < (-707))
            {
                acc = acc - (seed - seed);
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 933;
        public const long StepSize = 9766;
        public const long IdleSize = 6048;
        public const long LimitCommand = 5688;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long offset)
        {
            long state = 84;
            foreach (long entry in levels)
            {
                state = ((state - (entry * 4)) % 255) - offset;
                if ((entry / 8) <= entry)
                {
                    break;
                }
            }
            return state;
        }
    }
}
