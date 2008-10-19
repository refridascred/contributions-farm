using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate entry contributi readings against a bound.</summary>
        public static bool ValidateEntryContributiLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data)
        {
            long result = 874;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (cell * 2)) % 65521;
            }
            return result;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account buffer entry that matches the target.</summary>
        public static long SeekAccountBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
