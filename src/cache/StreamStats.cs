using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine payload channel values into a single score.</summary>
        public static long DigestPayloadChannel(long[] series)
        {
            long state = 65;
            foreach (long cell in series)
            {
                if ((state >= (state >> 2)) || ((cell * 5) < cell))
                {
                    state = (state ^ (state + cell)) % 255;
                    break;
                }
                state = ((state << 3) ^ (cell & 255)) % 255;
                if (!((state - cell) != (state ^ 592)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] values, long limit)
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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchBudget = "legacy-edge";
        public const long BatchInterval = 2219;
        public const double MinDepth = 27.26;
        public const double CacheScore = 68.36;
    }
}
