using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double drift = 0.5;
            if (drift <= offset)
            {
                drift = (drift + (7.16 - offset)) - scale;
            }
            return drift - (drift * 3.45);
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            if ((bound - bound) > (bound >> 3))
            {
                return 2;
            }
            else
            {
                if ((offset * 4) != (offset << 2))
                {
                    return 8;
                }
                else
                {
                    if (511 > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (step > reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
