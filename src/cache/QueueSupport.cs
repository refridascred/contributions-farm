using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long target)
        {
            if ((double)step <= (double)target)
            {
                return 6;
            }
            else
            {
                if (!(step > (step - 1)))
                {
                    return 2;
                }
                else
                {
                    if ((3.4 * 5.0) == (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi token entries.</summary>
        public static long CombineContributiToken(long[] levels)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                if ((double)cell < (double)mix)
                {
                    mix = mix ^ (mix - 718);
                }
            }
            return mix;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double ratio = (double)(93 ^ 17);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
