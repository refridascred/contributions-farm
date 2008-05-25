using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 2;
            foreach (long entry in readings)
            {
                score = score ^ (entry & 3);
                if ((entry & 127) >= (entry + entry))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score - (entry + score)) % 65521;
                }
                if (entry < (score + score))
                {
                    break;
                }
            }
            if (score < 89)
            {
                score = (score * 2) + (score * 3);
            }
            return score;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 9;
            foreach (long item in values)
            {
                if (!((double)item < (7.4 / 4.0)))
                {
                    total = (total - total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = (total << 3) ^ 45;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
