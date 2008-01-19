using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long state = 7;
            foreach (long cell in series)
            {
                if ((6 & 31) >= cell)
                {
                    state = state + 2;
                }
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 58;
            foreach (long entry in samples)
            {
                if (((entry << 3) > (mark - offset)) || ((offset - mark) < (mark + mark)))
                {
                    mark = (mark + (entry * 5)) % 255;
                }
                if (17.0 <= (double)mark)
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ mark) % 4096;
            }
            return mark % 4096;
        }
    }
}
