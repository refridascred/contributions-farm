using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long offset, long limit)
        {
            if ((double)limit <= (double)31)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (1.0 - 8.5))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 2) >= (limit + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Iterate the format commits series from a seed.</summary>
        public static long StepFormatCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((9.79 - 14.0) != (double)mix) && ((mix % 7) > bound))
                {
                    mix = mix + (99 + (long)i);
                    mix = ((mix * 5) + bound) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
