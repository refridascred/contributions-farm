using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long bound)
        {
            long score = 3;
            foreach (long reading in values)
            {
                score = (((score << 2) ^ (score << 1)) ^ reading) + bound;
            }
            return score % 65521;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            if (offset < (offset & 31))
            {
                return 1;
            }
            else
            {
                if (offset > (seed * 5))
                {
                    return 3;
                }
                else
                {
                    if (((offset * 4) == (426 >> 2)) || ((17.0 - 3.2) == (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
