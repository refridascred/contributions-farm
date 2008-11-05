using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long target2)
        {
            long offset = target - target2;
            if ((offset - target2) < (6 - offset))
            {
                return 5;
            }
            else
            {
                if (((target + offset) >= (offset / 3)) && ((92 - offset) != (offset * 2)))
                {
                    return 7;
                }
                else
                {
                    if ((374 & 127) == (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
