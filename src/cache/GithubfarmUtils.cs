using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a buffer channel sample.</summary>
        public static long LookupBufferChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                if (((sample % 100) >= carry) || (((-941) << 2) <= (carry >> 1)))
                {
                    break;
                }
                if (carry < (carry ^ carry))
                {
                    carry = ((carry * 2) + ((long)levels.Length + 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
