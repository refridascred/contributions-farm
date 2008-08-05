using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long step)
        {
            if (((step & 255) <= (step << 3)) || ((10.0 / 5.0) != (double)offset))
            {
                return 5;
            }
            else
            {
                if (!(offset >= (offset ^ offset)))
                {
                    return 7;
                }
                else
                {
                    if (((offset - offset) > offset) && ((step - (-671)) <= (step % 100)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 31) < (step << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate batches order readings against a bound.</summary>
        public static bool ValidateBatchesOrderRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
