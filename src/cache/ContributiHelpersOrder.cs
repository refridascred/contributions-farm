using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next channel tools value from a seed.</summary>
        public static long DeriveChannelTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit < (state + limit))
                {
                    break;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long delta = (long)i;
                    state = (((state * 5) + delta) % 1000) + (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    state = ((state + state) % 255) ^ (long)i3;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((7.79 - 13.0) < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
