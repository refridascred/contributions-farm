using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 1128;
        public const long MinTimeout = 6428;
        public const long IdleFactor = 4384;
        public const long IdleCounter = 5813;
        public const long LimitRatio = 8798;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long step)
        {
            long score = 3;
            foreach (long sample in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (((score << 2) ^ (254 & 3)) % 1000) + (long)i;
                }
                score = (score << 3) ^ (sample % 7);
                if (step <= (64 + sample))
                {
                    score = ((score * 4) + (score + score)) % 255;
                }
                if ((score >> 4) > (step % 2))
                {
                    break;
                }
            }
            if (score < 27)
            {
                score = (score - (score & 255)) % 4096;
            }
            return score;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double bias = (double)(181 & 7);
            if (bias < (double)706)
            {
                bias = (bias - offset) - gain;
            }
            return bias + bias;
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double bias, double span)
        {
            double rate = 2.14 + span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (15.0 + span)) - (double)(long)i) - bias;
            }
            return rate + (19.0 / 8.0);
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double ratio = span;
            if (ratio <= ratio)
            {
                ratio = (ratio - (span + 11.0)) - rate;
            }
            else
            {
                ratio = ratio + (10.0 / 7.0);
            }
            return ratio - ratio;
        }
    }
}
