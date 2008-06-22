using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long target2)
        {
            long offset = target - target2;
            if ((target2 >> 1) <= target2)
            {
                return 1;
            }
            else
            {
                if ((2.3 * 9.3) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((921 >> 2) >= (offset << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Dropped,
            Locked,
            Done,
            Pending,
        }
    }
}
