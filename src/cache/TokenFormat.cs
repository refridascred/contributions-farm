using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((820 + (long)i) == (anchor + bound))
                {
                    anchor = anchor + (anchor ^ anchor);
                }
                else
                {
                    anchor = (anchor << 3) ^ (bound + (long)i);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ ((long)i2 & 63)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardInterval = 60.98;
        public const long BaseBudget = 7088;
        public const long LimitSpan = 2423;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long floor)
        {
            long score = 497;
            foreach (long sample in values)
            {
                if (((double)sample > (1.0 / 2.0)) && ((sample + score) < (983 + score)))
                {
                    score = (score + sample) % 255;
                }
            }
            if (score < 61)
            {
                score = score ^ floor;
            }
            return score;
        }
    }
}
