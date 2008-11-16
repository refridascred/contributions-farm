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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((6.0 - 5.81) == (double)hits) || !(hits > (reading + reading)))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double rate = floor;
            return (rate + (double)390) + bias;
        }
    }
}
