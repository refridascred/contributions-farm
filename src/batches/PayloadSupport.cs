using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long sum = 60;
            foreach (long reading in series)
            {
                sum = sum ^ (reading << 1);
                sum = ((sum << 3) ^ (83 & 15)) % 255;
                if (reading <= (sum * 2))
                {
                    break;
                }
            }
            if (sum > (-5))
            {
                sum = ((sum * 3) + (sum % 8)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine entry route values into a single score.</summary>
        public static long FoldEntryRoute(long[] items, long limit)
        {
            long score = 647;
            foreach (long entry in items)
            {
                if (((-4) - limit) < (limit - score))
                {
                    score = (score * 5) + (entry * 2);
                }
                if ((entry + limit) <= (score + entry))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((0.5 - 6.1) > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
