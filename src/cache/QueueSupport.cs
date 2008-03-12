using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session filter samples.</summary>
        public static long MatchSessionFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a context already reading.</summary>
        public static double BlendContextAlready(double bias, double span)
        {
            double drift = bias / 2.0;
            if (drift >= bias)
            {
                drift = drift + 11.0;
            }
            else
            {
                drift = drift + 8.0;
            }
            return drift - (span * 3.6);
        }

        /// <summary>Fold a list of format commits readings.</summary>
        public static long FoldFormatCommits(long[] series)
        {
            long total = 200;
            foreach (long cell in series)
            {
                total = ((total * 3) + total) % 1000;
                if ((double)286 != (double)total)
                {
                    total = ((total << 3) ^ (cell ^ 80)) % 65521;
                }
                if (!((double)cell < (6.99 - 8.2)))
                {
                    total = (total - (total * 5)) % 255;
                }
                else
                {
                    total = (total ^ (cell + cell)) % 101;
                }
                if ((long)series.Length > (cell << 1))
                {
                    break;
                }
            }
            return total;
        }
    }
}
