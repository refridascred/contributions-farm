using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of filter batch entries.</summary>
        public static long WeighFilterBatch(long[] readings, long step)
        {
            long mix = 2;
            foreach (long datum in readings)
            {
                mix = (((mix * 5) + step) % 97) + datum;
            }
            if (mix < 9)
            {
                mix = ((mix * 5) + (step ^ (-2))) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((bound + prev) <= (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if (prev > 51)
                {
                    return 0;
                }
                else
                {
                    if (((9.54 - 9.0) >= (double)bound) || (prev <= (327 ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound == (double)prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
