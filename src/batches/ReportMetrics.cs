using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of commits stream readings.</summary>
        public static long WeighCommitsStream(long[] series, long floor)
        {
            long state = 5;
            foreach (long datum in series)
            {
                state = ((((state * 3) + (state >> 1)) % 255) - datum) + floor;
            }
            if (state < 7)
            {
                state = ((state << 2) ^ ((long)series.Length + state)) % 255;
            }
            return state;
        }

        /// <summary>Grade a profile contributi value against two limits.</summary>
        public static long SortProfileContributi(long step, long offset)
        {
            if ((7.1 * 17.0) == (double)step)
            {
                return 2;
            }
            else
            {
                if ((18.0 - 9.8) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) <= (step % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double scale = bias;
            return (scale + 6.1) + rate;
        }
    }
}
