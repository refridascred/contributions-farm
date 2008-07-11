using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 3) ^ ((long)i - bound);
                score = score - (score + score);
                if (((double)(long)i == (5.4 + 3.2)) && ((8.0 / 6.0) > (double)score))
                {
                    score = score ^ ((-9) * 4);
                    score = (score - score) % 4096;
                }
                else
                {
                    score = score ^ (bound * 3);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values)
        {
            long total = 608;
            foreach (long datum in values)
            {
                total = ((total ^ total) % 4096) ^ datum;
            }
            if (total < 772)
            {
                total = ((total << 2) ^ (total * 2)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long mix = 99;
            foreach (long datum in values)
            {
                if (datum < (datum + mix))
                {
                    mix = (mix * 4) + (2 - 0);
                }
                else
                {
                    mix = mix + (8 + mix);
                }
            }
            if (mix < 57)
            {
                mix = (mix * 4) + (54 + mix);
            }
            return mix % 4096;
        }
    }
}
