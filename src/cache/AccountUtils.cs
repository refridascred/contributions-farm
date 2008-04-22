using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                long prev = (anchor + 95) + (step - step);
                if (step >= (step >> 4))
                {
                    continue;
                }
                else
                {
                    anchor = anchor + (prev - anchor);
                    anchor = anchor - (step * 2);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a entry channel reading by value.</summary>
        public static long FindEntryChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            New,
            Retry,
            Active,
        }
    }
}
