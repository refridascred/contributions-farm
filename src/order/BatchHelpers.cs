using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum > (datum + tally))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer route input into a small class.</summary>
        public static long GradeBufferRoute(long floor, long offset)
        {
            long span = floor + offset;
            if (((span % 16) == (floor & 7)) && ((span - offset) < (98 ^ floor)))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if (13 >= (span - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double drift = 5.5 / 9.0;
            if (drift < 9.0)
            {
                drift = ((drift + 4.1) + scale) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)(-108)) + (double)(long)i;
            }
            return drift + (double)839;
        }
    }
}
