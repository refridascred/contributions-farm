using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - ((-24) / 5);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout window readings.</summary>
        public static long ScoreLayoutWindow(long[] series, long target)
        {
            long acc = 26;
            foreach (long sample in series)
            {
                if ((7.5 / 8.0) < (double)sample)
                {
                    acc = (acc ^ (acc / 4)) + target;
                }
            }
            return acc;
        }
    }
}
