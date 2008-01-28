using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (4.0 + 7.9))
                {
                    seen = ((seen + 2) ^ cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double rate2 = (double)(9 * 3);
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + rate) + (double)(long)i) - floor;
            }
            return rate2 + rate;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long offset)
        {
            long anchor = 6;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 1000;
                if ((offset > (cell - offset)) && ((19 ^ 46) >= (cell + 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
