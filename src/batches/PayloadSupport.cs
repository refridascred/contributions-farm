using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally & 15) > datum) && (target < (datum & 15)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(limit < total))
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((long)i > (target & 31)))
                {
                    score = (score + (target % 60)) % 4096;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
