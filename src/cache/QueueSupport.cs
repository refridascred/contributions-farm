using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool GuardQueueNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data, long offset)
        {
            long sum = 85;
            foreach (long item in data)
            {
                if ((sum - offset) != (item + item))
                {
                    sum = (sum + item) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (item >> 5)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                state = ((state * 2) + 4) ^ cell;
            }
            return state;
        }
    }
}
