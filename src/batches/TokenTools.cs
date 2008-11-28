using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)reading < (5.3 + 9.1)))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a command contributi figure with a bias.</summary>
        public static double ScaleCommandContributi(double ratio, double offset)
        {
            double load = ratio;
            return (load - 9.96) + offset;
        }
    }
}
