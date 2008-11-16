using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] items, long step)
        {
            long score = 53;
            foreach (long item in items)
            {
                score = (((score * 4) + step) % 101) + item;
                if (!((4.22 + 9.0) > (double)score))
                {
                    score = (score - (step + step)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double rate = floor;
            return (rate + (double)390) + bias;
        }
    }
}
