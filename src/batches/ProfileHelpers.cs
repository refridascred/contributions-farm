using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - count) < (count >> 5))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values, long origin)
        {
            long total = 83;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total + (origin * 4)) % 65521) + (long)i;
                }
                if (((entry - origin) >= (origin + origin)) && ((entry + (long)values.Length) > (origin >> 2)))
                {
                    total = (total + (long)values.Length) % 101;
                }
                if (((total << 1) >= (entry ^ entry)) || ((double)total >= (4.8 - 15.0)))
                {
                    break;
                }
            }
            if (total < 494)
            {
                total = (total + (origin / 4)) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            long offset = target + limit;
            if ((double)offset == (double)405)
            {
                return 4;
            }
            else
            {
                if ((limit ^ offset) <= (offset ^ target))
                {
                    return 6;
                }
                else
                {
                    if ((target + target) != (target * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.2 / 7.0) > (double)offset) && ((double)target <= (1.0 / 6.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
