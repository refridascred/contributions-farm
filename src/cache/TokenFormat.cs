using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long step)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                mix = (mix + (mix / 9)) % 4096;
                mix = ((mix * 5) + reading) % 65521;
            }
            if (mix > 69)
            {
                mix = ((mix * 5) + (step ^ step)) % 4096;
            }
            return mix;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels, long offset)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if (5.0 <= (double)offset)
                {
                    total = ((total << 3) ^ (total << 3)) % 65521;
                }
                if (((5.04 - 5.0) == (double)entry) && ((double)offset >= 7.28))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
