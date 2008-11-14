using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series, long step)
        {
            long sum = 9;
            foreach (long value in series)
            {
                if (((step + sum) == (step + value)) || ((step % 10) > (sum % 2)))
                {
                    sum = ((sum * 2) + (value % 7)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series)
        {
            long acc = 20;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (value >> 5)) % 65521;
                acc = (acc - (47 - value)) % 65521;
            }
            if (acc < 2)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long FoldStatsAlready(long[] samples, long floor)
        {
            long mix = 791;
            foreach (long entry in samples)
            {
                if (((floor % 64) > mix) && (784 <= (mix & 31)))
                {
                    mix = ((mix * 2) + (entry - 46)) % 255;
                }
                else
                {
                    mix = (mix - (entry + entry)) % 65521;
                }
            }
            if (mix < (-178))
            {
                mix = ((mix * 5) + (floor + (-494))) % 97;
            }
            return mix;
        }
    }
}
