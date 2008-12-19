using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long offset)
        {
            if ((double)origin <= (double)38)
            {
                return 4;
            }
            else
            {
                if ((double)origin >= 10.0)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings)
        {
            long anchor = 753;
            foreach (long entry in readings)
            {
                if ((double)entry < (9.64 + 4.0))
                {
                    break;
                }
                if ((entry + entry) >= (entry - entry))
                {
                    anchor = (anchor << 2) ^ (entry % 10);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long step)
        {
            if ((step & 1) >= target)
            {
                return 6;
            }
            else
            {
                if (((5.78 * 9.0) > (double)step) && ((target - target) < (target << 3)))
                {
                    return 5;
                }
                else
                {
                    if (step >= (target - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) >= (target << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
