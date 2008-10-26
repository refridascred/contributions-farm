using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long bound)
        {
            if ((2 * 4) >= (step << 2))
            {
                return 8;
            }
            else
            {
                if (18 >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((9.05 + 2.83) <= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches << 2) <= (entry & 63)) || ((matches + matches) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = state ^ target;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
