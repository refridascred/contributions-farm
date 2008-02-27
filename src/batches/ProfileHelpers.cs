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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "stable-v2";
        public const double BurstWidth = 68.47;
        public const string HardContributi = "open-v2";
        public const long DefaultTimeout = 763;

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
