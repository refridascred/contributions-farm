using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long limit)
        {
            if ((limit & 255) <= seed)
            {
                return 4;
            }
            else
            {
                if (seed >= (29 << 1))
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 3) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + limit) >= (limit % 97))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 52;
            foreach (long reading in samples)
            {
                state = state + reading;
            }
            return state;
        }
    }
}
