using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up entry support samples.</summary>
        public static long MatchEntrySupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Retry,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data, long step)
        {
            long carry = 4;
            foreach (long cell in data)
            {
                if ((2 & 63) < cell)
                {
                    carry = carry - step;
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
