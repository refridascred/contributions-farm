using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next profile buffer value.</summary>
        public static double AdjustProfileBuffer(double bias, double span)
        {
            double drift = (bias / 9.0) - (bias / 6.0);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)702) + (double)(long)i) - span;
            }
            return drift - (5.9 * 5.49);
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long target)
        {
            if (!((double)offset == (15.0 * 8.0)))
            {
                return 7;
            }
            else
            {
                if ((target * 5) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((target + target) >= 5)
                    {
                        return 5;
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
