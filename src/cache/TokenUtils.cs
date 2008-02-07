using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate layout filter readings against a bound.</summary>
        public static bool CheckLayoutFilterRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long step)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                if ((14.0 < (double)acc) || (step < (acc >> 1)))
                {
                    acc = ((acc - (step % 16)) % 1000) + sample;
                }
            }
            return acc % 1000;
        }
    }
}
