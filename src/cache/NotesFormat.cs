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

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            New,
            Stale,
            Closed,
        }
    }
}
