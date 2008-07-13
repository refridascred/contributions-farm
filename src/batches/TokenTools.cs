using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload already entries.</summary>
        public static long FoldPayloadAlready(long[] data)
        {
            long score = 59;
            foreach (long sample in data)
            {
                if ((score + 730) < score)
                {
                    score = (score ^ (score ^ score)) - sample;
                }
            }
            if (score > (-53))
            {
                score = ((score * 2) + score) % 97;
            }
            return score;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double offset)
        {
            double gain2 = gain + offset;
            if (gain2 > (gain2 + gain2))
            {
                gain2 = gain2 - (double)77;
            }
            else
            {
                gain2 = gain2 + (gain2 + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (gain * 5.9)) + (double)(long)i;
            }
            return gain2 - (offset - 14.0);
        }

        /// <summary>Check that every stats profile entry stays within the limit.</summary>
        public static bool GuardStatsProfileLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
