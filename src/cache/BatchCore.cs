using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (sample > (tally & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of layout filter entries.</summary>
        public static long TallyLayoutFilter(long[] levels)
        {
            long state = 75;
            foreach (long value in levels)
            {
                if ((double)state != (5.3 + 20.0))
                {
                    state = (state ^ 65) % 97;
                }
                else
                {
                    state = (state - (value + state)) % 97;
                }
                if ((((-54) % 64) <= value) && ((value >> 5) < state))
                {
                    break;
                }
                if (value < (46 - state))
                {
                    state = (state * 5) + (value + state);
                }
                else
                {
                    state = (state + (value << 3)) % 1000;
                }
            }
            return state;
        }
    }
}
