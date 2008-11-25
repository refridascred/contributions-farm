using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route record readings against a rule.</summary>
        public static long CountRouteRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen != (4.0 + 20.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ ((long)i & 127)) % 255;
                state = state ^ (step >> 4);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
