using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long step)
        {
            long cur = offset ^ step;
            if (((step + cur) == (step & 127)) && ((offset ^ cur) <= step))
            {
                return 1;
            }
            else
            {
                if (cur > (offset >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (double)528)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((seed - entry) < (matches / 9))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
