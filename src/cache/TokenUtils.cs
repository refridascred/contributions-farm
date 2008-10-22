using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long step)
        {
            long sum = 3;
            foreach (long cell in series)
            {
                if (step > (cell / 8))
                {
                    sum = (sum ^ step) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
            }
            if (sum < 3)
            {
                sum = sum - (591 + sum);
            }
            return sum;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6 ^ hits) >= (reading % 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (mix >= (54 / 3))
                {
                    mix = ((mix << 3) ^ (mix + 658)) % 65521;
                    mix = ((mix * 4) + mix) % 97;
                    break;
                }
                mix = (mix * 2) + (mix << 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
