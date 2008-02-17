using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long step)
        {
            if ((step - limit) > (step + limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (double)687)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (acc * 5);
                acc = (acc - (acc + acc)) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
