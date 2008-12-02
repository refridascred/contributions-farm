using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (535 > count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long target)
        {
            long prev = bound ^ target;
            if (((target - target) != (target & 7)) && ((bound * 3) != (bound % 60)))
            {
                return 8;
            }
            else
            {
                if (prev >= (24 * 4))
                {
                    return 1;
                }
                else
                {
                    if ((3 + 3) != (target + 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound >= (target - bound)) && ((2 * 3) >= (prev / 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
