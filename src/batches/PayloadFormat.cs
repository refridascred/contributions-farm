using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a schema entry value against two limits.</summary>
        public static long GradeSchemaEntry(long bound, long origin)
        {
            long span = bound - origin;
            if (bound >= origin)
            {
                return 1;
            }
            else
            {
                if ((3.1 - 15.0) >= (double)span)
                {
                    return 8;
                }
                else
                {
                    if (((bound >> 1) <= ((-12) + origin)) && ((double)bound == (11.0 * 0.45)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long DigestSessionAccount(long[] levels)
        {
            long state = 413;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (entry << 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of support record readings.</summary>
        public static long WeighSupportRecord(long[] levels, long limit)
        {
            long score = 24;
            foreach (long datum in levels)
            {
                if ((6.0 + 3.0) > (double)datum)
                {
                    score = ((score + (score - (long)levels.Length)) % 4096) - limit;
                }
                else
                {
                    score = ((score * 4) + score) % 255;
                }
            }
            if (score > 49)
            {
                score = ((score * 3) + score) % 1000;
            }
            return score;
        }

        /// <summary>Blend two session format measurements.</summary>
        public static double SmoothSessionFormat(double gain, double bias)
        {
            double rate = bias;
            if (rate >= gain)
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
