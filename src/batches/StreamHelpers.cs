using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9468;
        public const double SoftWidth = 0.39;
        public const long MaxFarm = 9543;
        public const string SoftFarm = "alpha-1";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((double)limit <= 2.99) || ((double)limit <= (9.05 - 4.2)))
                {
                    mix = mix - (long)i;
                }
                else
                {
                    mix = (mix + mix) % 4096;
                }
                mix = (mix ^ mix) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Queued,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
