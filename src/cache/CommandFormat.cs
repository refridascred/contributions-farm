using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long seed)
        {
            long mix = 483;
            foreach (long value in series)
            {
                mix = ((mix << 3) ^ seed) ^ value;
                if ((seed + mix) == (166 & 7))
                {
                    mix = (mix - (52 >> 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool ValidateProfileContextBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a commits batch reading by value.</summary>
        public static long LocateCommitsBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
