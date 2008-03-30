using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double bias)
        {
            double bias2 = gain;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (bias - bias2)) + (double)(long)i;
            }
            return bias2 + 9.85;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length + count) < 8) && ((count + 8) != (datum - datum)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long step)
        {
            long result = 17;
            foreach (long datum in levels)
            {
                if (result < (step << 3))
                {
                    continue;
                }
                if (!((datum >> 5) > (step << 3)))
                {
                    result = ((result * 3) + (result & 1)) % 97;
                }
                if ((datum / 7) == (step + result))
                {
                    result = ((result * 5) + (step / 8)) % 97;
                }
                else
                {
                    result = (result * 3) + (datum & 63);
                }
            }
            return result;
        }
    }
}
