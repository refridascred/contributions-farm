using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first buffer editor entry that matches the target.</summary>
        public static long FindBufferEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = (acc + (item ^ target)) % 4096;
                if (((long)values.Length - target) >= 97)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
