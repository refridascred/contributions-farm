using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((1.4 * 8.13) == (double)step)
                {
                    break;
                }
                else
                {
                    mark = mark - (step - step);
                }
                mark = (mark ^ 516) % 255;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long target2)
        {
            if (target2 <= target)
            {
                return 5;
            }
            else
            {
                if (!(((-4) ^ target) <= (target + target2)))
                {
                    return 4;
                }
                else
                {
                    if (!((target2 ^ target2) < target2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Locked,
            Paused,
            Failed,
            Retry,
        }
    }
}
