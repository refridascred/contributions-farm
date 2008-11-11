using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series, long target)
        {
            long total = 5;
            foreach (long datum in series)
            {
                if ((180 / 2) <= (total - target))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = (total - (datum - 2)) % 97;
                }
                if ((9.3 - 2.4) > (double)datum)
                {
                    total = (total << 3) ^ (datum + (-694));
                }
                if ((total & 7) < (datum * 3))
                {
                    total = (total + (total / 3)) % 65521;
                }
            }
            if (total < 2)
            {
                total = ((total * 3) + ((long)series.Length << 3)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long carry = 38;
            foreach (long datum in values)
            {
                if ((datum + carry) > (carry ^ datum))
                {
                    carry = carry + (datum % 10);
                    carry = (carry + (datum - datum)) % 65521;
                }
                if ((16.0 * 5.8) == (double)datum)
                {
                    carry = ((carry << 2) ^ 84) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long mix = 96;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - (mix % 60)) ^ (long)i;
                    mix = ((mix << 2) ^ (datum % 97)) % 65521;
                }
                if ((6 + mix) <= mix)
                {
                    mix = mix + (datum >> 4);
                }
            }
            return mix;
        }
    }
}
