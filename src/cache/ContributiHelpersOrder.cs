using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank route stats input into a small class.</summary>
        public static long GradeRouteStats(long offset, long seed)
        {
            long cur = offset ^ seed;
            if ((cur + cur) != (cur - seed))
            {
                return 6;
            }
            else
            {
                if (cur > (cur + cur))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of window channel readings.</summary>
        public static long CompareWindowChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
