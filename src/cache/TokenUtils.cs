using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a command contributi counter forward.</summary>
        public static long IterateCommandContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((877 + datum) != (datum - 5))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + limit) == ((-4) << 1))
                {
                    mix = mix ^ ((-68) ^ limit);
                }
                else
                {
                    mix = mix - (limit << 3);
                }
                mix = (mix - (mix + limit)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
