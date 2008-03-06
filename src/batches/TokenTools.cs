using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks already readings.</summary>
        public static long TallyChecksAlready(long[] data)
        {
            long anchor = -77;
            foreach (long reading in data)
            {
                anchor = anchor - (reading + anchor);
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
